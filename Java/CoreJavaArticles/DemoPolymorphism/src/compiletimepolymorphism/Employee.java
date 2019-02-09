package compiletimepolymorphism;

public class Employee {
	private int id;
	private String name;
	
	public Employee(int id, String name) {
		this.id = id;
		this.name = name;
	}
	
	public void displayInfo() {
		System.out.println("Employee Id: " + id);
		System.out.println("Employee name: " + name);
	}
	
	public void displayInfo(int id) {
		this.id = id;
		System.out.println("Employee Id: " + id);
	}
	
	public void displayInfo(String name) {
		
		this.name = name;
		System.out.println("Employee name: " + name);
	}
}
