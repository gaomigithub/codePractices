package lab4;

public class RRProcess extends UserProcess {

	public RRProcess(int id, int arrival, int burst, int priority) {
		super(id, arrival, burst, priority);
		// TODO Auto-generated constructor stub
	}
	
	@Override
	public int compareTo(UserProcess p) {
		int pri2 = p.getPriority();
		if (priority > pri2)
			return 1;
		else if (priority < pri2)
			return -1;
		else
			return 0;
	}

}
