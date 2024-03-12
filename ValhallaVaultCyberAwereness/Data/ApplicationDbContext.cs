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
		public DbSet<TicketModel> UserTickets { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

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

			modelBuilder.Entity<Category>().HasData(
new Category { CategoryId = 1, Categories = "Att skydda sig mot bedrägerier" },
new Category { CategoryId = 2, Categories = "Cybersäkerhet för företag" },
new Category { CategoryId = 3, Categories = "Cyberspionage" }
);

			modelBuilder.Entity<Segment>().HasData(
			new Segment { SegmentId = 1, SegmentTitle = "Del 1", CategoryId = 1 },
			new Segment { SegmentId = 2, SegmentTitle = "Del 2", CategoryId = 1 },
			new Segment { SegmentId = 3, SegmentTitle = "Del 3", CategoryId = 1 },
			new Segment { SegmentId = 4, SegmentTitle = "Del 1", CategoryId = 2 },
			new Segment { SegmentId = 5, SegmentTitle = "Del 2", CategoryId = 2 },
			new Segment { SegmentId = 6, SegmentTitle = "Del 3", CategoryId = 2 },
			new Segment { SegmentId = 7, SegmentTitle = "Del 4", CategoryId = 2 },
			new Segment { SegmentId = 8, SegmentTitle = "Del 1", CategoryId = 3 },
			new Segment { SegmentId = 9, SegmentTitle = "Del 4", CategoryId = 3 },
			new Segment { SegmentId = 10, SegmentTitle = "Del 4", CategoryId = 3 }


			);

			modelBuilder.Entity<Question>().HasData(
			 new Question()
			 {
				 QuestionId = 1,
				 Title = "Kreditkortsbedrägeri",
				 Questions = "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att " +
				 "\"säkerställa din kontos säkerhet\" " +
				 "efter en påstådd säkerhetsincident. " +
				 "Hur bör du tolka denna situation?",

				 PossibleAnswers = new List<string>
				{
		"Ett Legitimt försök från banken att skydda ditt konto",
		"En informationsinsamling för en marknadsundersökning",
		"Ett potentiellt telefonbedrägeri"
				},
				 CorrectAnswer = "Ett potentiellt telefonbedrägeri",
				 Explanation = "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri.",
				 SegmentId = 1
			 },
			 new Question()
			 {
				 QuestionId = 2,
				 Title = "Romansbedrägeri",
				 Questions = "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?",

				 PossibleAnswers = new List<string>
				{
		"En legitim begäran om hjälp från en person i nöd",
		"Ett romansbedrägeri",
		"En tillfällig ekonomisk svårighet"
				},
				 CorrectAnswer = "Ett romansbedrägeri",
				 Explanation = "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri.",
				 SegmentId = 1
			 },
			 new Question()
			 {
				 QuestionId = 3,
				 Title = "Telefonbedrägeri",
				 Questions = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?",

				 PossibleAnswers = new List<string>
				{
		"Ett misstag av kreditkortsföretaget",
		"Kreditkortsbedrägeri",
		"Obehöriga köp av en familjemedlem"
				},
				 CorrectAnswer = "Kreditkortsbedrägeri",
				 Explanation = "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri.",
				 SegmentId = 1
			 },
			 new Question()
			 {
				 QuestionId = 4,
				 Title = "Bedrägerier i hemmet",
				 SegmentId = 2
			 },
			new Question()
			{
				QuestionId = 5,
				Title = "Identitetsstöld",
				SegmentId = 2
			},
			new Question()
			{
				QuestionId = 6,
				Title = "Nätfiske och bluffmejl",
				SegmentId = 2
			},
			new Question()
			{
				QuestionId = 7,
				Title = "Investeringsbedrägeri på nätet",
				SegmentId = 2
			},
			new Question()
			{
				QuestionId = 8,
				Title = "Abonnemangsfällor och falska fakturor",
				SegmentId = 3
			},
			new Question()
			{
				QuestionId = 9,
				Title = "Ransomware",
				SegmentId = 3
			},
			new Question()
			{
				QuestionId = 10,
				Title = "Statistik och förhållningssätt",
				SegmentId = 3
			},
			new Question()
			{
				QuestionId = 11,
				Title = "Digital säkerhet på företag",
				Questions = "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?",

				PossibleAnswers = new List<string>
				{
		"Utbildning i digital säkerhet för alla anställda",
		"Installera en starkare brandvägg",
		"Byta ut all IT-utrustning"
				},
				CorrectAnswer = "Utbildning i digital säkerhet för alla anställda",
				Explanation = "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.",
				SegmentId = 4
			},
			new Question()
			{
				QuestionId = 12,
				Title = "Risker och beredskap",
				Questions = "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?",

				PossibleAnswers = new List<string>
				{
		"Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder",
		"Ignorera problemet tills en patch kan utvecklas",
		"Stänga ner tjänsten tillfälligt"
				},
				CorrectAnswer = "Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder",
				Explanation = "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.",
				SegmentId = 4
			},
			new Question()
			{
				QuestionId = 13,
				Title = "Aktörer inom cyberbrott",
				Questions = "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?",

				PossibleAnswers = new List<string>
				{
		"En enskild hackare med ett personligt vendetta",
		"En konkurrerande företagsentitet",
		"Organiserade cyberbrottsliga grupper"
				},
				CorrectAnswer = "Organiserade cyberbrottsliga grupper",
				Explanation = "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.",
				SegmentId = 4
			},
			new Question()
			{
				QuestionId = 14,
				Title = "Ökad digital närvaro och distansarbete",
				Questions = "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?",

				PossibleAnswers = new List<string>
				{
		"Återgå till kontorsarbete",
		"Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
		"Förbjuda användning av personliga enheter för arbete"
				},
				CorrectAnswer = "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
				Explanation = "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.",
				SegmentId = 4
			},
			new Question()
			{
				QuestionId = 15,
				Title = "Cyberangrepp mot känsliga sektorer",
				Questions = "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?",

				PossibleAnswers = new List<string>
				{
		"Phishing",
		"Ransomware",
		"Spyware"
				},
				CorrectAnswer = "Ransomware",
				Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.",
				SegmentId = 4
			},
			new Question()
			{
				QuestionId = 16,
				Title = "Cyberrånet mot Mersk",
				Questions = "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?",

				PossibleAnswers = new List<string>
				{
		"Spyware",
		"Ransomware",
		"Adware"
				},
				CorrectAnswer = "Ransomware",
				Explanation = "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system.\r\nMaersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.",
				SegmentId = 4
			},
			new Question()
			{
				QuestionId = 17,
				Title = "Social engineering",
				SegmentId = 5
			},
			new Question()
			{
				QuestionId = 18,
				Title = "Nätfiske och skräppost",
				SegmentId = 5
			},
			new Question()
			{
				QuestionId = 19,
				Title = "Vishing",
				SegmentId = 5
			},
			new Question()
			{
				QuestionId = 20,
				Title = "Varning för vishing",
				SegmentId = 5
			},
			new Question()
			{
				QuestionId = 21,
				Title = "Identifiera VD-mejl",
				SegmentId = 5
			},
			new Question()
			{
				QuestionId = 22,
				Title = "Öneangrepp och presentkortsbluffar",
				SegmentId = 5
			},
			new Question()
			{
				QuestionId = 23,
				Title = "Virus, maskar och trojaner",
				SegmentId = 6
			},
			new Question()
			{
				QuestionId = 24,
				Title = "Så kan det gå till",
				SegmentId = 6
			},
			new Question()
			{
				QuestionId = 25,
				Title = "Nätverksintrång",
				SegmentId = 6
			},
			new Question()
			{
				QuestionId = 26,
				Title = "Dataintrång",
				SegmentId = 6
			},
			new Question()
			{
				QuestionId = 27,
				Title = "Hackad!",
				SegmentId = 6
			},
			new Question()
			{
				QuestionId = 28,
				Title = "Vägarna in",
				SegmentId = 6
			},
			new Question()
			{
				QuestionId = 29,
				Title = "Utpressningsvirus",
				SegmentId = 7
			},
			new Question()
			{
				QuestionId = 30,
				Title = "Attacker mot servrar",
				SegmentId = 7
			},
			new Question()
			{
				QuestionId = 31,
				Title = "Cyberangrepp i Norden",
				SegmentId = 7
			},
			new Question()
			{
				QuestionId = 32,
				Title = "It-brottslingarnas verktyg",
				SegmentId = 7
			},
			new Question()
			{
				QuestionId = 33,
				Title = "Mirai, Wannacry och fallet Düsseldorf",
				SegmentId = 7
			},
			new Question()
			{
				QuestionId = 34,
				Title = "De sårbara molnen",
				SegmentId = 7
			},
			new Question()
			{
				QuestionId = 35,
				Title = "Allmänt om cyberspionage",
				Questions = "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?",

				PossibleAnswers = new List<string>
				{
		"Cyberkriminalitet",
		"Cyberspionage",
		"Cyberterrorism"
				},
				CorrectAnswer = "Cyberspionage",
				Explanation = "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande, typiskt för politiska, militära eller ekonomiska fördelar.",
				SegmentId = 8
			},
			new Question()
			{
				QuestionId = 36,
				Title = "Metoder för cyberspionage",
				Questions = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?",

				PossibleAnswers = new List<string>
				{
		"Social ingenjörskonst",
		"Massövervakning",
		"Riktade cyberattacker"
				},
				CorrectAnswer = "Riktade cyberattacker",
				Explanation = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day sårbarheter är en avancerad metod för cyberspionage där angriparen specifikt riktar in sig på ett mål för att komma åt känslig information eller data genom att utnyttja tidigare okända sårbarheter i programvara.",
				SegmentId = 8
			},
			new Question()
			{
				QuestionId = 37,
				Title = "Säkerhetsskyddslagen",
				Questions = "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?",

				PossibleAnswers = new List<string>
				{
		"GDPR",
		"Säkerhetsskyddslagen",
		"IT-säkerhetslagen"
				},
				CorrectAnswer = "Säkerhetsskyddslagen",
				Explanation = "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information från spioneri, sabotage, terroristbrott och andra säkerhetshot. Lagen ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.",
				SegmentId = 8
			},
			new Question()
			{
				QuestionId = 38,
				Title = "Cyberspionagets aktörer",
				Questions = "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?",

				PossibleAnswers = new List<string>
				{
		"Oberoende hackare",
		"Aktivistgrupper",
		"Statssponsrade hackers"
				},
				CorrectAnswer = "Statssponsrade hackers",
				Explanation = "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering för att genomföra cyberspionage, ofta riktat mot utländska intressen, organisationer eller regeringar för att få strategiska fördelar.",
				SegmentId = 8
			},
			new Question()
			{
				QuestionId = 39,
				Title = "Värvningsförsök",
				SegmentId = 9
			},
			new Question()
			{
				QuestionId = 40,
				Title = "Affärsspionage",
				SegmentId = 9
			},
			new Question()
			{
				QuestionId = 41,
				Title = "Påverkanskampanjer",
				SegmentId = 9
			},
			new Question()
			{
				QuestionId = 42,
				Title = "Svensk underrättelsetjänst och cyberförsvar",
				SegmentId = 10
			},
			new Question()
			{
				QuestionId = 43,
				Title = "Signalspaning, informationssäkerhet och 5G",
				SegmentId = 10
			},
			new Question()
			{
				QuestionId = 44,
				Title = "Samverkan mot cyberspionage",
				SegmentId = 10
			}
				);

		}
	}
}