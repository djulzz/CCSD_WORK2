<?php

class Student
{
	private $FirstName;
	private $LastName;
	private $Id;

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

	public function __construct()
	{
		$this->ServerName = "localhost";
		$this->UserName = "root";
		$this->Password = "";
		$this->Connection = new mysqli( $this->ServerName, $this->UserName, $this->Password );

		// check connection
	}
}

// Actual Running Code
$class = new Course();
$class->AddStudent( 1, "Julien", "Esposito" );
$class->AddStudent( 2, "Jordan", "Gross" );
$class->Display();

//$Student[] = Student::withParams( 1, "Julien", "Esposito" );

?>
