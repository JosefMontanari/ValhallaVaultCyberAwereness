using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValhallaVaultCyberAwereness.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Categories" },
                values: new object[,]
                {
                    { 1, "Network Security" },
                    { 2, "Web Application Security" },
                    { 3, "Mobile Security" },
                    { 4, "Cloud Security" }
                });

            migrationBuilder.InsertData(
                table: "Segments",
                columns: new[] { "SegmentId", "CategoryId", "SegmentTitle" },
                values: new object[,]
                {
                    { 1, 1, "Penetration Testing" },
                    { 2, 1, "Incident Response" },
                    { 3, 2, "Secure Coding" },
                    { 4, 2, "Authentication & Authorization" },
                    { 5, 3, "Mobile App Security" },
                    { 6, 3, "Device Security" },
                    { 7, 4, "Cloud Architecture Security" },
                    { 8, 4, "Data Encryption in the Cloud" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "CorrectAnswer", "PossibleAnswers", "Questions", "SegmentId" },
                values: new object[,]
                {
                    { 2, "Computer Security Incident Response Team", "[\"Computer Security Incident Response Team\",\"Cyber Security Information Retrieval Tool\",\"Corporate Security Incident Resolution Team\"]", "In the context of incident response, what does 'CSIRT' stand for?", 2 },
                    { 3, "To prevent vulnerabilities and reduce the risk of exploitation", "[\"To prevent vulnerabilities and reduce the risk of exploitation\",\"To increase server performance\",\"To enhance user interface design\"]", "Why is secure coding important in web development?", 3 },
                    { 4, "To filter and control incoming and outgoing network traffic", "[\"To filter and control incoming and outgoing network traffic\",\"To improve website performance\",\"To design graphical user interfaces\"]", "What is the purpose of a firewall in network security?", 1 },
                    { 5, "A type of security attack where malicious scripts are injected into web pages", "[\"A type of security attack where malicious scripts are injected into web pages\",\"A programming language for web development\",\"A protocol for secure data transfer\"]", "What does the term 'Cross-Site Scripting (XSS)' refer to?", 2 },
                    { 6, "By requiring users to provide two forms of identification before granting access", "[\"By requiring users to provide two forms of identification before granting access\",\"By encrypting data on the server\",\"By blocking all incoming network traffic\"]", "How does two-factor authentication enhance security?", 3 },
                    { 7, "To create a secure and encrypted connection over the internet", "[\"To create a secure and encrypted connection over the internet\",\"To manage virtual private servers\",\"To monitor network traffic for vulnerabilities\"]", "What is the main purpose of a VPN in network security?", 1 },
                    { 8, "Granting users the minimum levels of access needed to perform their jobs", "[\"Granting users the minimum levels of access needed to perform their jobs\",\"Providing maximum access to all users by default\",\"Restricting access only to administrators\"]", "What is the principle of least privilege in access control?", 4 },
                    { 9, "Using parameterized queries and prepared statements", "[\"Using parameterized queries and prepared statements\",\"Increasing server processing power\",\"Encrypting all database entries\"]", "What is a common method to protect against SQL injection attacks?", 3 },
                    { 10, "To filter and monitor HTTP traffic between a web application and the internet", "[\"To filter and monitor HTTP traffic between a web application and the internet\",\"To optimize website loading speed\",\"To manage domain name registrations\"]", "What is the purpose of a WAF (Web Application Firewall) in web security?", 2 },
                    { 11, "An attempt to trick individuals into revealing sensitive information", "[\"An attempt to trick individuals into revealing sensitive information\",\"A type of malware that encrypts files and demands a ransom\",\"A method of securing communication channels\"]", "What does the term 'phishing' refer to in cybersecurity?", 2 },
                    { 12, "To use unique physical or behavioral traits for user identification", "[\"To use unique physical or behavioral traits for user identification\",\"To store passwords in a secure database\",\"To encrypt data during transmission\"]", "What is the purpose of biometric authentication?", 3 },
                    { 13, "Identifying vulnerabilities in a network or system", "[\"Identifying vulnerabilities in a network or system\",\"Testing code for security flaws\",\"Managing server configurations\"]", "What is the primary goal of a penetration tester?", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "SegmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "SegmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "SegmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "SegmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "SegmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "SegmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "SegmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Segments",
                keyColumn: "SegmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "CorrectAnswer", "PossibleAnswers", "Questions", "SegmentId" },
                values: new object[] { 1, "Sunny", "[\"Rainy\",\"Sunny\",\"Wet\"]", "Whats the weather today?", null });
        }
    }
}
