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
new Category { CategoryId = 1, Categories = "Att skydda sig mot bedr�gerier" },
new Category { CategoryId = 2, Categories = "Cybers�kerhet f�r f�retag" },
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
				 Title = "Kreditkortsbedr�geri",
				 Questions = "Du f�r ett ov�ntat telefonsamtal fr�n n�gon som p�st�r sig vara fr�n din bank. Personen ber dig bekr�fta ditt kontonummer och l�senord f�r att " +
				 "\"s�kerst�lla din kontos s�kerhet\" " +
				 "efter en p�st�dd s�kerhetsincident. " +
				 "Hur b�r du tolka denna situation?",

				 PossibleAnswers = new List<string>
				{
		"Ett Legitimt f�rs�k fr�n banken att skydda ditt konto",
		"En informationsinsamling f�r en marknadsunders�kning",
		"Ett potentiellt telefonbedr�geri"
				},
				 CorrectAnswer = "Ett potentiellt telefonbedr�geri",
				 Explanation = "Banker och andra finansiella institutioner beg�r aldrig k�nslig information s�som kontonummer eller l�senord via telefon. Detta �r ett klassiskt tecken p� telefonbedr�geri.",
				 SegmentId = 1
			 },
			 new Question()
			 {
				 QuestionId = 2,
				 Title = "Romansbedr�geri",
				 Questions = "Efter flera m�nader av daglig kommunikation med n�gon du tr�ffade p� en datingsida, b�rjar personen ber�tta om en pl�tslig finansiell kris och ber om din hj�lp genom att �verf�ra pengar. Vad indikerar detta mest sannolikt?",

				 PossibleAnswers = new List<string>
				{
		"En legitim beg�ran om hj�lp fr�n en person i n�d",
		"Ett romansbedr�geri",
		"En tillf�llig ekonomisk sv�righet"
				},
				 CorrectAnswer = "Ett romansbedr�geri",
				 Explanation = "Beg�ran om pengar, s�rskilt under omst�ndigheter d�r tv� personer aldrig har tr�ffats fysiskt, �r ett vanligt tecken p� romansbedr�geri.",
				 SegmentId = 1
			 },
			 new Question()
			 {
				 QuestionId = 3,
				 Title = "Telefonbedr�geri",
				 Questions = "Efter en online-shoppingrunda m�rker du oidentifierade transaktioner p� ditt kreditkortsutdrag fr�n f�retag du aldrig handlat fr�n. Vad indikerar detta mest sannolikt?",

				 PossibleAnswers = new List<string>
				{
		"Ett misstag av kreditkortsf�retaget",
		"Kreditkortsbedr�geri",
		"Obeh�riga k�p av en familjemedlem"
				},
				 CorrectAnswer = "Kreditkortsbedr�geri",
				 Explanation = "Oidentifierade transaktioner p� ditt kreditkortsutdrag �r en stark indikation p� att ditt kortnummer har komprometterats och anv�nts f�r obeh�riga k�p, vilket �r typiskt f�r kreditkortsbedr�geri.",
				 SegmentId = 1
			 },
			 new Question()
			 {
				 QuestionId = 4,
				 Title = "Bedr�gerier i hemmet",
				 SegmentId = 2
			 },
			new Question()
			{
				QuestionId = 5,
				Title = "Identitetsst�ld",
				SegmentId = 2
			},
			new Question()
			{
				QuestionId = 6,
				Title = "N�tfiske och bluffmejl",
				SegmentId = 2
			},
			new Question()
			{
				QuestionId = 7,
				Title = "Investeringsbedr�geri p� n�tet",
				SegmentId = 2
			},
			new Question()
			{
				QuestionId = 8,
				Title = "Abonnemangsf�llor och falska fakturor",
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
				Title = "Statistik och f�rh�llningss�tt",
				SegmentId = 3
			},
			new Question()
			{
				QuestionId = 11,
				Title = "Digital s�kerhet p� f�retag",
				Questions = "Inom f�retaget m�rker man att konfidentiella dokument regelbundet l�cker ut till konkurrenter. Efter en intern granskning uppt�cks det att en anst�lld omedvetet har installerat skadlig programvara genom att klicka p� en l�nk i ett phishing-e-postmeddelande. Vilken �tg�rd b�r prioriteras f�r att f�rhindra framtida incidenter?",

				PossibleAnswers = new List<string>
				{
		"Utbildning i digital s�kerhet f�r alla anst�llda",
		"Installera en starkare brandv�gg",
		"Byta ut all IT-utrustning"
				},
				CorrectAnswer = "Utbildning i digital s�kerhet f�r alla anst�llda",
				Explanation = "Utbildning i digital s�kerhet �r avg�rande f�r att hj�lpa anst�llda att k�nna igen och undvika s�kerhetshot som phishing, vilket �r en vanlig attackvektor.",
				SegmentId = 4
			},
			new Question()
			{
				QuestionId = 12,
				Title = "Risker och beredskap",
				Questions = "Inom f�retaget uppt�ckts det en s�rbarhet i v�r programvara som kunde m�jligg�ra obeh�rig �tkomst till anv�ndardata. F�retaget har inte omedelbart en l�sning. Vilken �r den mest l�mpliga f�rsta �tg�rden?",

				PossibleAnswers = new List<string>
				{
		"Informera alla anv�ndare om s�rbarheten och rekommendera tempor�ra skydds�tg�rder",
		"Ignorera problemet tills en patch kan utvecklas",
		"St�nga ner tj�nsten tillf�lligt"
				},
				CorrectAnswer = "Informera alla anv�ndare om s�rbarheten och rekommendera tempor�ra skydds�tg�rder",
				Explanation = "Transparent kommunikation och r�dgivning om tillf�lliga �tg�rder �r avg�rande f�r att skydda anv�ndarna medan en permanent l�sning utvecklas.",
				SegmentId = 4
			},
			new Question()
			{
				QuestionId = 13,
				Title = "Akt�rer inom cyberbrott",
				Questions = "V�rt f�retag blir m�ltavla f�r en DDoS-attack som �verv�ldigar v�ra servers och g�r v�ra tj�nster otillg�ngliga f�r kunder. Vilken typ av akt�r �r mest sannolikt ansvarig f�r denna typ av attack?",

				PossibleAnswers = new List<string>
				{
		"En enskild hackare med ett personligt vendetta",
		"En konkurrerande f�retagsentitet",
		"Organiserade cyberbrottsliga grupper"
				},
				CorrectAnswer = "Organiserade cyberbrottsliga grupper",
				Explanation = "DDoS-attacker kr�ver ofta betydande resurser och koordinering, vilket �r karakteristiskt f�r organiserade cyberbrottsliga grupper.",
				SegmentId = 4
			},
			new Question()
			{
				QuestionId = 14,
				Title = "�kad digital n�rvaro och distansarbete",
				Questions = "Med �verg�ngen till distansarbete uppt�cker v�rt f�retag en �kning av s�kerhetsincidenter, inklusive obeh�rig �tkomst till f�retagsdata. Vilken �tg�rd b�r f�retaget vidta f�r att adressera denna nya riskmilj�?",

				PossibleAnswers = new List<string>
				{
		"�terg� till kontorsarbete",
		"Inf�ra striktare l�senordspolicyer och tv�faktorsautentisering f�r fj�rr�tkomst",
		"F�rbjuda anv�ndning av personliga enheter f�r arbete"
				},
				CorrectAnswer = "Inf�ra striktare l�senordspolicyer och tv�faktorsautentisering f�r fj�rr�tkomst",
				Explanation = "St�rkt autentisering �r kritisk f�r att s�kra fj�rr�tkomst och skydda mot obeh�rig �tkomst i en distribuerad arbetsmilj�.",
				SegmentId = 4
			},
			new Question()
			{
				QuestionId = 15,
				Title = "Cyberangrepp mot k�nsliga sektorer",
				Questions = "H�lsov�rdsmyndigheten uts�tts f�r ett cyberangrepp som krypterar patientdata och kr�ver l�sen f�r att �terst�lla �tkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta f�r?",

				PossibleAnswers = new List<string>
				{
		"Phishing",
		"Ransomware",
		"Spyware"
				},
				CorrectAnswer = "Ransomware",
				Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kr�ver l�sen f�r dekryptering, vilket �r s�rskilt skadligt f�r kritiska sektorer som h�lsov�rd.",
				SegmentId = 4
			},
			new Question()
			{
				QuestionId = 16,
				Title = "Cyberr�net mot Mersk",
				Questions = "Det globala fraktbolaget Maersk blev offer f�r ett omfattande cyberangrepp som avsev�rt st�rde deras verksamhet v�rlden �ver. Vilken typ av malware var prim�rt ansvarig f�r denna incident?",

				PossibleAnswers = new List<string>
				{
		"Spyware",
		"Ransomware",
		"Adware"
				},
				CorrectAnswer = "Ransomware",
				Explanation = "Maersk utsattes f�r NotPetya ransomware-angreppet, som ledde till omfattande st�rningar och f�rluster genom att kryptera f�retagets globala system.\r\nMaersk rapporterade att f�retaget led ekonomiska f�rluster p� grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna f�r st�rningar i deras globala verksamheter, �terst�llande av system och data, samt f�rlust av aff�rer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt f�retag och tj�nar som en kraftfull p�minnelse om de potentiella konsekvenserna av cyberhot.",
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
				Title = "N�tfiske och skr�ppost",
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
				Title = "Varning f�r vishing",
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
				Title = "�neangrepp och presentkortsbluffar",
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
				Title = "S� kan det g� till",
				SegmentId = 6
			},
			new Question()
			{
				QuestionId = 25,
				Title = "N�tverksintr�ng",
				SegmentId = 6
			},
			new Question()
			{
				QuestionId = 26,
				Title = "Dataintr�ng",
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
				Title = "V�garna in",
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
				Title = "Mirai, Wannacry och fallet D�sseldorf",
				SegmentId = 7
			},
			new Question()
			{
				QuestionId = 34,
				Title = "De s�rbara molnen",
				SegmentId = 7
			},
			new Question()
			{
				QuestionId = 35,
				Title = "Allm�nt om cyberspionage",
				Questions = "Regeringen uppt�cker att k�nslig politisk kommunikation har l�ckt och misst�nker elektronisk �vervakning. Vilket fenomen beskriver b�st denna situation?",

				PossibleAnswers = new List<string>
				{
		"Cyberkriminalitet",
		"Cyberspionage",
		"Cyberterrorism"
				},
				CorrectAnswer = "Cyberspionage",
				Explanation = "Cyberspionage avser aktiviteter d�r akt�rer, ofta statliga, engagerar sig i �vervakning och datainsamling genom cybermedel f�r att erh�lla hemlig information utan m�lets medgivande, typiskt f�r politiska, milit�ra eller ekonomiska f�rdelar.",
				SegmentId = 8
			},
			new Question()
			{
				QuestionId = 36,
				Title = "Metoder f�r cyberspionage",
				Questions = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day s�rbarheter f�r att infiltrera deras n�tverk och stj�la oerh�rt viktig data. Vilken metod f�r cyberspionage anv�nds sannolikt h�r?",

				PossibleAnswers = new List<string>
				{
		"Social ingenj�rskonst",
		"Mass�vervakning",
		"Riktade cyberattacker"
				},
				CorrectAnswer = "Riktade cyberattacker",
				Explanation = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day s�rbarheter �r en avancerad metod f�r cyberspionage d�r angriparen specifikt riktar in sig p� ett m�l f�r att komma �t k�nslig information eller data genom att utnyttja tidigare ok�nda s�rbarheter i programvara.",
				SegmentId = 8
			},
			new Question()
			{
				QuestionId = 37,
				Title = "S�kerhetsskyddslagen",
				Questions = "Regeringen i Sverige �kar sitt interna s�kerhetsprotokoll f�r att skydda sig mot utl�ndska underr�ttelsetj�nsters infiltration. Vilken lagstiftning ger ramverket f�r detta skydd?",

				PossibleAnswers = new List<string>
				{
		"GDPR",
		"S�kerhetsskyddslagen",
		"IT-s�kerhetslagen"
				},
				CorrectAnswer = "S�kerhetsskyddslagen",
				Explanation = "S�kerhetsskyddslagen �r en svensk lagstiftning som syftar till att skydda nationellt k�nslig information fr�n spioneri, sabotage, terroristbrott och andra s�kerhetshot. Lagen st�ller krav p� s�kerhetsskydds�tg�rder f�r verksamheter av betydelse f�r Sveriges s�kerhet.",
				SegmentId = 8
			},
			new Question()
			{
				QuestionId = 38,
				Title = "Cyberspionagets akt�rer",
				Questions = "Lunds universitet uppt�cker att forskningsdata om ny teknologi har stulits. Unders�kningar tyder p� en v�lorganiserad grupp med kopplingar till en utl�ndsk stat. Vilken typ av akt�r ligger sannolikt bakom detta?",

				PossibleAnswers = new List<string>
				{
		"Oberoende hackare",
		"Aktivistgrupper",
		"Statssponsrade hackers"
				},
				CorrectAnswer = "Statssponsrade hackers",
				Explanation = "Statssponsrade hackers �r akt�rer som arbetar p� uppdrag av eller med st�d fr�n en regering f�r att genomf�ra cyberspionage, ofta riktat mot utl�ndska intressen, organisationer eller regeringar f�r att f� strategiska f�rdelar.",
				SegmentId = 8
			},
			new Question()
			{
				QuestionId = 39,
				Title = "V�rvningsf�rs�k",
				SegmentId = 9
			},
			new Question()
			{
				QuestionId = 40,
				Title = "Aff�rsspionage",
				SegmentId = 9
			},
			new Question()
			{
				QuestionId = 41,
				Title = "P�verkanskampanjer",
				SegmentId = 9
			},
			new Question()
			{
				QuestionId = 42,
				Title = "Svensk underr�ttelsetj�nst och cyberf�rsvar",
				SegmentId = 10
			},
			new Question()
			{
				QuestionId = 43,
				Title = "Signalspaning, informationss�kerhet och 5G",
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