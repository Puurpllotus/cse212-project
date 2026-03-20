using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities
    // Expected Result: Highest priority item is removed first
    // Defect(s) Found: Initially highest priority was not always selected correctly
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("A", 1);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 3);

        Assert.AreEqual("B", pq.Dequeue());
    }
    [TestMethod]
    // Scenario: Add items with same priority
    // Expected Result: First inserted item is removed first (FIFO)
    // Defect(s) Found: FIFO order was violated when using >= instead of >
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("A", 5);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 5);

        Assert.AreEqual("A", pq.Dequeue());
        Assert.AreEqual("B", pq.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: Exception thrown
    // Defect(s) Found: None after fix
    public void TestPriorityQueue_Empty()
    {
        var pq = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Mix enqueue and dequeue
    // Expected Result: Correct priority behavior maintained
    // Defect(s) Found: Removal bug caused duplicate returns
    public void TestPriorityQueue_Mixed()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("A", 2);
        pq.Enqueue("B", 4);

        Assert.AreEqual("B", pq.Dequeue());

        pq.Enqueue("C", 5);

        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
    }
}