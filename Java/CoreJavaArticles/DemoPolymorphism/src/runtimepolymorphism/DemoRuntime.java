package runtimepolymorphism;

public class DemoRuntime {

	public static void main(String[] args) {
		//class1 holds object of Class1
		Class1 class1 = new Class1();
		class1.displayMessage();
		
		//class2 holds object of Class2
		Class1 class2 = new Class2();
		class2.displayMessage();
		
		//class22 holds object of Class2
		Class2 class22 = new Class2();
		class22.displayMessage();
	}

}
