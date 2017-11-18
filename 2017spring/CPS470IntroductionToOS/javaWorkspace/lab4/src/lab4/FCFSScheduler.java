package lab4;

import java.util.Collections;

public class FCFSScheduler extends Scheduler {
	
	@Override
	protected void executeUserProcess() {
		quantum = current.getBurst();
		current.execute(quantum, clock);
		}
}
