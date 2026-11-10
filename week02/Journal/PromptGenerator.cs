public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Was there something I wanted to do but didn't get around to doing?",
        "What's one thing I'm grateful for today?",
        "What emotion have you been avoiding lately, and why?",
        "Describe yourself today without mentioning your job, your roles, or your relationships.",
        "If you could only accomplish one thing this week, what should it be?",
        "Did anything unexpected happen today?",
        "Did I do anything outside my comfort zone?",
        "Did I make any progress toward my goals?",
        "What's something I'm looking forward to tomorrow?",
        "If I could give today's version of myself a message, what would I say?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }

}