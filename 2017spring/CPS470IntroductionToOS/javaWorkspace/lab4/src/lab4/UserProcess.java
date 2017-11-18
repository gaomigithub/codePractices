package lab4;

/**
 * User process
 * 
 * In each time slot allocated to the process, it "runs" (sleep in simulation)
 * for the given quantum.
 * 
 * Modify this class to include more features of a user process, such as
 * arrival time, burst time, waiting time, turnaround time, etc. Also need to
 * change how the processes are compared to determine their ordering.
 *
 */

public class UserProcess implements Comparable<UserProcess> { 
	
	protected int pid;
	protected int arrival;
	protected int burst;
	protected int priority;
	protected int remaining;
	protected int start;
	protected int end;
	
	
	public UserProcess(int id, int arrival, int burst, int priority) {
		this.pid = id;
		this.arrival = arrival;
		this.burst = burst;
		this.priority = priority;
		this.remaining = burst;
		this.start = arrival;
		this.end = arrival;
	}
	
	public int getStart() {
		return start;
	}
	
	public int getEnd() {
		return end;
	}
	
	public int getBurst() {
		return burst;
	}
	
	public int getRemaining() {
		return remaining;
	}
	
	public int getProcessId() {
		return pid;
	}

	public int getPriority() {
		// TODO Auto-generated method stub
		return priority;
	}

	public int getArrival() {
		// TODO Auto-generated method stub
		return arrival;
	}

	public void execute(int quantum, int curTime) {
		System.out.printf("Running process %d ...\n", pid);
		try {
			Thread.sleep(quantum);
			if (remaining < quantum) {
				end = curTime + remaining;
			}
			remaining -= quantum;
			if (remaining > 0) {
				System.out.println("Process " + pid + ": Remaining = " + remaining);
			}
		}
		catch(InterruptedException ex) { };
	}
	
	/**
	 * Implement the method of the Comparable interface.
	 */
	public int compareTo(UserProcess p) {
		int pid2 = p.getProcessId();
		if (pid > pid2)
			return 1;
		else if (pid < pid2)
			return -1;
		else
			return 0;
	}

}