package demoexceptionhandling;

public class DemoException {

	public static void main(String[] args) throws Exception {
		try {
			int i = 5/0;
		} catch (ArithmeticException e) {
			System.out.println("An error occured. Message: " + e.getMessage());
		} catch (Exception e) {
			throw e;
		} finally {
			//code to release resources
		}
	}

}
