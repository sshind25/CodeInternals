package demoConstructors;

public class Employee extends Department {
	private int id;
	private String name;
	
	public Employee(){
		this(0, "dummy", "dummyDepartment");
	}
	
	public Employee(int id, String name, String deptName) {
		super(deptName);
		this.id = id;
		this.name = name;
	}
	
	public void DisplayInfo() {
		System.out.println("Employee id: " + id);
		System.out.println("Employee name: " + name);
	}
}
