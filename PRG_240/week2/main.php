<?php

class Student
{
	private $FirstName;
	private $LastName;
	private $Id;

	public function Get_FirstName() { return $this->FirstName; }
	public function Get_LastName() { return $this->LastName; }
	public function Get_ID() { return $this->Id; }

    public static function withParams( $_id, $_FirstName, $_LastName ) {
        $instance = new self();
        $instance->FirstName = $_FirstName;
        $instance->LastName = $_LastName;
        $instance->Id = $_id;
        return $instance;
    }

	public function __construct()
	{
		$this->FirstName = "John";
		$this->LastName = "Doe";
	}

	public function __destruct()
	{
	}


	public function Display()
	{
		print "You are $this->FirstName $this->LastName and id = $this->Id<br/>";
	}
}

class Course
{
	private $StudentCount;
	private $Student;

	public function GetStudentAt( $index )
	{
		return $this->Student[ $index ];
	}

	public function __construct()
	{
		$this->StudentCount = 0;
		$this->Student = array();
	}

	public function AddStudent( $_id, $_FirstName, $_LastName )
	{
		$student = Student::withParams( $_id, $_FirstName, $_LastName );
		$this->Student[] = $student;
		$this->StudentCount = $this->StudentCount + 1;
	}

	public function Display()
	{
		for( $i = 0; $i < $this->StudentCount; $i++ ) {
			$this->Student[ $i ]->Display();
		}
	}

	public function __destruct()
	{
		print( "Course - Destructor called<br/>");
		unset( $this->Student );
	}
}


class SqlConnectionManager
{
	private $ServerName;
	private $UserName;
	private $Password;
	private $Connection;
	private $DBName;

	public function __destruct()
	{
		print( "Destroying the DB Connection!!<br/>");
		mysqli_close( $this->Connection );
		unset( $this->Connection );
	}

	public function AddStudent( $Student )
	{
		$id = $Student->Get_ID();
		$firstname = $Student->Get_FirstName();
		$lastname = $Student->Get_LastName();

		$query_string = "INSERT INTO STUDENTS (ID, FIRST_NAME, LAST_NAME) VALUES( $id, '$firstname', '$lastname' )";
		if( $this->Connection->query( $query_string) === TRUE )
		{
    		echo "New record created successfully<br/>";
    	}
    	else
    	{
    		echo "Error: " . $query_string . "<br/>" . $this->Connection->error . "<br/>";
		}
	}

	public function __construct()
	{
		$this->ServerName = "localhost";
		$this->UserName = "root";
		$this->Password = "";
		$this->DBName = "COURSE";
		$this->Connection = new mysqli( $this->ServerName, $this->UserName, $this->Password, $this->DBName );

		// check connection
		if( $this->Connection->connect_error )
		{
			die( "Connection failed: " . $this->Connection->connect_error );
		}

		print( "Connected successfully<br/>" );
	}
}

// Actual Running Code
$class = new Course();
$class->AddStudent( 1, "Julien", "Esposito" );
$class->AddStudent( 2, "Jordan", "Gross" );
$class->Display();

$database = new SqlConnectionManager();
for( $i = 0; $i < 2; $i++ ) {
	$current_student = $class->GetStudentAt( $i );
	$database->AddStudent( $current_student );
}

?>
