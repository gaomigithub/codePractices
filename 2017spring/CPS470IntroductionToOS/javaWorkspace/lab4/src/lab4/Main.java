package lab4;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

/**
 * @author Mi Gao
 * @date 2017-06-08
 * 
 * Driver of CPU scheduling (NOT COMPLETED YET)
 * 
 * 
 * Modify it to include creating processes from information in the
 * data file and algorithm selection that will affect the order in which
 * the processes are entered to the scheduler's queue and the
 * time slice quantum.
 * 
 */

public class Main {

	Scheduler sch;
	
	public static void main(String[] args) {
		new Main();
	}
	
	public Main() {
		Scanner kb = new Scanner(System.in);
		int selection = 0;
		do {
			System.out.println("Select which scheduling algorithm to use through 1 to 3:");
			System.out.println("1. First Come First Serve");
			System.out.println("2. Shortest Job First");
			System.out.println("3. Round Robin");
			selection = kb.nextInt();
		} while(selection < 1 || selection >3);
		createScheduler(selection);
		
		createProcesses("processData.txt",selection);
//		sch = new Scheduler();
//		createProcess("processData.txt");
		sch.start();
		try {
				synchronized(sch) {
				sch.wait();		// wait for CPUScheduler to finish
				CalculateStatistics();
			}
		}
		catch (Exception e) {}
	}
	
	private void createScheduler(int selection) {
		switch(selection) {
		case 1: // FCFS
			sch = new FCFSScheduler();
			break;
		case 2: // SJF
			sch = new SJFScheduler();
			break;
		case 3: // RR
			sch = new RRScheduler();
			break;
			default:
				System.out.println("Invalid selection");
				break;
		}
	}
	
	private void createProcesses(String fname, int selection) {
		File fp = new File(fname);
		Scanner ifp = null;
		try {
			ifp = new Scanner(fp);
		} catch (FileNotFoundException e) {
			System.out.println("Invaild file name:" + fname);
			e.printStackTrace();
		}
		
		int pid, arrival, burst, priority;
		String line = ifp.nextLine();
		while (ifp.hasNextLine()) {
			pid = ifp.nextInt();
			arrival = ifp.nextInt();
			burst = ifp.nextInt();
			priority = ifp.nextInt();
			UserProcess p = new UserProcess(pid, arrival, burst, priority);
			sch.addUserProcess(p);
			System.out.printf("Process %d added to queue\n", p.getProcessId());
		}
		System.out.println();
	}
	
//	private void createProcesses(String fname) {
//		for (int i = 1; i <= 5; i++) {
//			UserProcess p = new UserProcess(i);
//			sch.addUserProcess(p);
//			System.out.printf("Process %d added to queue\n", p.getProcessId());
//		}
//		System.out.println();
//	}
	
	private void CalculateStatistics() {
		System.out.println("\n---------------------------------------------------\n");
//		 calculate statistics such as average turnaround time and
//		 average waiting time.
		System.out.println("Done");
	}

}