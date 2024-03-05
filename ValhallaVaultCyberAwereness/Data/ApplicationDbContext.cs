using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{


		public DbSet<Question> Questions { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Segment> Segments { get; set; }
		public DbSet<AnswerUser> UserAnswers { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{



			//modelBuilder.Entity<Segment>()
			//.HasMany(s => s.Question) // har flera questions
			//.WithOne(q => q.Segment)
			//.HasForeignKey(q => q.SegmentId)
			//.OnDelete(DeleteBehavior.Cascade);

			//modelBuilder.Entity<Question>()
			//	.HasOne(q => q.Segment) // flera questions kan ha en segment
			//	.WithMany(s => s.Question)
			//	.HasForeignKey(q => q.SegmentId)
			//	.OnDelete(DeleteBehavior.Restrict);

			//modelBuilder.Entity<Category>().HasData(
			//new Category { CategoryId = 1, Categories = "Network Security" },
			//new Category { CategoryId = 2, Categories = "Web Application Security" },
			//new Category { CategoryId = 3, Categories = "Mobile Security" },
			//new Category { CategoryId = 4, Categories = "Cloud Security" }
			//);

			//modelBuilder.Entity<Segment>().HasData(
			//new Segment { SegmentId = 1, SegmentTitle = "Penetration Testing", CategoryId = 1 },
			//new Segment { SegmentId = 2, SegmentTitle = "Incident Response", CategoryId = 1 },
			//new Segment { SegmentId = 3, SegmentTitle = "Secure Coding", CategoryId = 2 },
			//new Segment { SegmentId = 4, SegmentTitle = "Authentication & Authorization", CategoryId = 2 },
			//new Segment { SegmentId = 5, SegmentTitle = "Mobile App Security", CategoryId = 3 },
			//new Segment { SegmentId = 6, SegmentTitle = "Device Security", CategoryId = 3 },
			//new Segment { SegmentId = 7, SegmentTitle = "Cloud Architecture Security", CategoryId = 4 },
			//new Segment { SegmentId = 8, SegmentTitle = "Data Encryption in the Cloud", CategoryId = 4 }
			//);

			//modelBuilder.Entity<Question>().HasData(
			// new Question
			// {
			//	 QuestionId = 1,
			//	 QuestionString = "What is the primary goal of a penetration tester?",
			//	 PossibleAnswers = new List<string>
			//	{
			//		"Identifying vulnerabilities in a network or system",
			//		"Testing code for security flaws",
			//		"Managing server configurations"
			//	},
			//	 CorrectAnswer = "Identifying vulnerabilities in a network or system",
			//	 SegmentId = 1
			// },
			//	new Question
			//	{
			//		QuestionId = 2,
			//		QuestionString = "In the context of incident response, what does 'CSIRT' stand for?",
			//		PossibleAnswers = new List<string>
			//	{
			//		"Computer Security Incident Response Team",
			//		"Cyber Security Information Retrieval Tool",
			//		"Corporate Security Incident Resolution Team"
			//	},
			//		CorrectAnswer = "Computer Security Incident Response Team",
			//		SegmentId = 2
			//	},
			//	new Question
			//	{
			//		QuestionId = 3,
			//		QuestionString = "Why is secure coding important in web development?",
			//		PossibleAnswers = new List<string>
			//	{
			//		"To prevent vulnerabilities and reduce the risk of exploitation",
			//		"To increase server performance",
			//		"To enhance user interface design"
			//	},
			//		CorrectAnswer = "To prevent vulnerabilities and reduce the risk of exploitation",
			//		SegmentId = 3
			//	},
			//	new Question
			//	{
			//		QuestionId = 4,
			//		QuestionString = "What is the purpose of a firewall in network security?",
			//		PossibleAnswers = new List<string>
			//	{
			//			"To filter and control incoming and outgoing network traffic",
			//			"To improve website performance",
			//			"To design graphical user interfaces"
			//	},
			//		CorrectAnswer = "To filter and control incoming and outgoing network traffic",
			//		SegmentId = 1
			//	},

			//	new Question
			//	{
			//		QuestionId = 5,
			//		QuestionString = "What does the term 'Cross-Site Scripting (XSS)' refer to?",
			//		PossibleAnswers = new List<string>
			//	{
			//		"A type of security attack where malicious scripts are injected into web pages",
			//		"A programming language for web development",
			//		"A protocol for secure data transfer"
			//	},
			//		CorrectAnswer = "A type of security attack where malicious scripts are injected into web pages",
			//		SegmentId = 2
			//	},

			//	new Question
			//	{
			//		QuestionId = 6,
			//		QuestionString = "How does two-factor authentication enhance security?",
			//		PossibleAnswers = new List<string>
			//	{
			//		"By requiring users to provide two forms of identification before granting access",
			//		"By encrypting data on the server",
			//		"By blocking all incoming network traffic"
			//	},
			//		CorrectAnswer = "By requiring users to provide two forms of identification before granting access",
			//		SegmentId = 3
			//	},
			//	 new Question
			//	 {
			//		 QuestionId = 7,
			//		 QuestionString = "What is the main purpose of a VPN in network security?",
			//		 PossibleAnswers = new List<string>
			//		{
			//			"To create a secure and encrypted connection over the internet",
			//			"To manage virtual private servers",
			//			"To monitor network traffic for vulnerabilities"
			//		},
			//		 CorrectAnswer = "To create a secure and encrypted connection over the internet",
			//		 SegmentId = 1
			//	 },

			//	new Question
			//	{
			//		QuestionId = 8,
			//		QuestionString = "What is the principle of least privilege in access control?",
			//		PossibleAnswers = new List<string>
			//		{
			//			"Granting users the minimum levels of access needed to perform their jobs",
			//			"Providing maximum access to all users by default",
			//			"Restricting access only to administrators"
			//		},
			//		CorrectAnswer = "Granting users the minimum levels of access needed to perform their jobs",
			//		SegmentId = 4
			//	},

			//	new Question
			//	{
			//		QuestionId = 9,
			//		QuestionString = "What is a common method to protect against SQL injection attacks?",
			//		PossibleAnswers = new List<string>
			//		{
			//			"Using parameterized queries and prepared statements",
			//			"Increasing server processing power",
			//			"Encrypting all database entries"
			//		},
			//		CorrectAnswer = "Using parameterized queries and prepared statements",
			//		SegmentId = 3
			//	},

			//	new Question
			//	{
			//		QuestionId = 10,
			//		QuestionString = "What is the purpose of a WAF (Web Application Firewall) in web security?",
			//		PossibleAnswers = new List<string>
			//		{
			//			"To filter and monitor HTTP traffic between a web application and the internet",
			//			"To optimize website loading speed",
			//			"To manage domain name registrations"
			//		},
			//		CorrectAnswer = "To filter and monitor HTTP traffic between a web application and the internet",
			//		SegmentId = 2
			//	},

			//	new Question
			//	{
			//		QuestionId = 11,
			//		QuestionString = "What does the term 'phishing' refer to in cybersecurity?",
			//		PossibleAnswers = new List<string>
			//		{
			//			"An attempt to trick individuals into revealing sensitive information",
			//			"A type of malware that encrypts files and demands a ransom",
			//			"A method of securing communication channels"
			//		},
			//		CorrectAnswer = "An attempt to trick individuals into revealing sensitive information",
			//		SegmentId = 2
			//	},

			//	new Question
			//	{
			//		QuestionId = 12,
			//		QuestionString = "What is the purpose of biometric authentication?",
			//		PossibleAnswers = new List<string>
			//		{
			//			"To use unique physical or behavioral traits for user identification",
			//			"To store passwords in a secure database",
			//			"To encrypt data during transmission"
			//		},
			//		CorrectAnswer = "To use unique physical or behavioral traits for user identification",
			//		SegmentId = 3
			//	}
			//	);

			base.OnModelCreating(modelBuilder);
		}
	}
}