using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add an item and remove it
    // Expected Result: the same item is returned
    // Defect(s) Found: Dequeue didn't remove the item correctly
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Joan", 1);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Joan", result);
    }

    [TestMethod]
    // Scenario: Add many items with different priorities
    // Expected Result: return the highest priority
    // Defect(s) Found: loop didn't recognize the last item
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("medium", 2);
        priorityQueue.Enqueue("high", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("high", result);

    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: same priority
    // Expected Result: fifo order
    // Defect(s) Found: the sign >=
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 2);

        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
    }
    
    [TestMethod]
    // Scenario: empty queue
    // Expected Result: exception thrown
    // Defect(s) Found: missing empty check
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}