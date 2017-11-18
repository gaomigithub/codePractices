package lab4;

/**
 * CPU scheduling.
 * 
 * The process at the front of the ready queue is schedule to run
 * up to "quantum" amount of time. If not finished, it is moved to
 * the end of the queue.
 * 
 * Modify the class to include different scheduling algorithms.
 */


import java.util.List;
import java.util.ArrayList;
import java.util.Queue;
import java.util.Random;
import java.util.LinkedList;
import java.util.Collections;

public class Scheduler extends Thread {
	
	final int defaultQuantum = 10;
	protected int quantum, curTime, clock;
	protected Queue<UserProcess> queue;
	protected UserProcess current;
	Random rdm = new Random(10000);
	private Queue<ProcessStats> stats;
	
	public Scheduler() {
		queue = new LinkedList<UserProcess>();
		clock = 0;
		quantum = defaultQuantum;
	}
	
	public void addUserProcess(UserProcess p) {
		queue.add(p);
	}

	private void executeUserProcess() {
		quantum = rdm.nextInt(2000); // simulate different time slices (random here)
		current.execute(quantum, curTime);
	}
	
	@Override
	public synchronized void run() {

		Collections.sort((List<UserProcess>)queue);
		while (!queue.isEmpty()) {
			current = queue.poll();  // remove the process from the queue
			executeUserProcess();
		}
		
		System.out.println("\nQueue is empty.");
		pause(1000);
		System.out.println("Scheduler shutdown ...");
		pause(1000);

		notify(); // notify the driver that the scheduler has finished.
	}

	private void pause(int n) {
		try {
			Thread.sleep(n);
		}
		catch(InterruptedException ex) { };
	}
	
	private void shuffleQueue() {
		List<UserProcess> list = new ArrayList<UserProcess>();
		for (UserProcess p : queue) {
			list.add(p);
		}
		Collections.shuffle(list);
		queue.clear();
		for (UserProcess p : list) {
			queue.offer(p);
		}
	}

}