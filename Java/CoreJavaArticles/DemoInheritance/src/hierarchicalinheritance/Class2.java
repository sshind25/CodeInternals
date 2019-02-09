package hierarchicalinheritance;

public class Class2 extends Class1 {
	private String message2;

	public String getMessage2() {
		return message2;
	}

	public void setMessage2(String message2) {
		this.message2 = message2;
	}
	
	public void displayMessage() {
		setMessage1("Hi, World");
		setMessage2("Hello, World");		
		System.out.println(getMessage1());
		System.out.println(getMessage2());		
	}
}
