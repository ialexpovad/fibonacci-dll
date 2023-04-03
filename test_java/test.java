
import com.sun.jna.Library;
import com.sun.jna.Native;
import com.sun.jna.Platform;
import com.sun.jna.ptr.FloatByReference;

public class test {

	public interface JNAApInterface extends Library {

		@SuppressWarnings("deprecation")
		JNAApInterface INSTANCE = (JNAApInterface) Native.loadLibrary("lib/fibonacci", JNAApInterface.class);
		void fibonacci_init(long a, long b);
		boolean fibonacci_next();
		long fibonacci_current();
		short fibonacci_index();
		
	}
	
	public void fibonacci_init(long a, long b) {
		JNAApInterface.INSTANCE.fibonacci_init(a, b);
	}
	public boolean fibonacci_next() {
 
		return JNAApInterface.INSTANCE.fibonacci_next();
		
	}
	public long fibonacci_current() {
		return JNAApInterface.INSTANCE.fibonacci_current();
	}
	public short fibonacci_index()
	{
		return JNAApInterface.INSTANCE.fibonacci_index();
	}
	
	
	    public static void main(String[] args) throws Exception {
	    	
	    	test ts = new test();	
	    	try { ts.fibonacci_init(1, 1); } catch (Exception exc) { throw new IllegalArgumentException("Failed initializing the Fibonacci relation sequence.", exc);}
	    	do { System.out.format("%d : %f", ts.fibonacci_index(), ts.fibonacci_current()); } while(ts.fibonacci_next());	    	
	    	System.out.format("%d : Fibonacci sequence values fit in an unsigned 64-bit integer.", ts.fibonacci_index() + 1);

	    }
}
