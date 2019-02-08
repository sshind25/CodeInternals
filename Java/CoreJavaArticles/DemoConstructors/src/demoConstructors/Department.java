package demoConstructors;

public class Employee extends Department {
	private int id;
	private String name;
	
	public Employee(){
		//Constructor chaining. Calling Parameterized constructor in same class
		this(0, "dummy", "dummyDepartment");
	}
	
	public Employee(int id, String name, String deptName) {
		//Constructor chaining. Calling base class constructor
		super(deptName);
		this.id = id;
		this.name = name;
	}
	
	public void DisplayInfo() {
		System.out.println("Employee id: " + id);
		System.out.println("Employee name: " + name);
		System.out.println("Department name: " + getDeptName());		
	}
}
