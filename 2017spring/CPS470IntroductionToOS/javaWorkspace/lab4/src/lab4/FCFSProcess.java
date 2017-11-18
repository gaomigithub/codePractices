package lab4;

public class FCFSProcess extends UserProcess {

	public FCFSProcess(int id, int arrival, int burst, int priority) {
		super(id, arrival, burst, priority);
		// TODO Auto-generated constructor stub
	}
	
	@Override
	public int compareTo(UserProcess p) {
		int arr2 = p.getArrival();
		if (arrival > arr2)
			return 1;
		else if (arrival < arr2)
			return -1;
		return 0;
	}

}
