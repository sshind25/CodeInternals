package hierarchicalinheritance;

public class Class3 extends Class1 {
	private String message3;

	public String getMessage3() {
		return message3;
	}

	public void setMessage3(String message3) {
		this.message3 = message3;
	}
	
	public void displayMessage() {
		setMessage1("Hi, World");		
		setMessage3("Hey, World");
		System.out.println(getMessage1());		
		System.out.println(getMessage3());
	}
}
