﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ValhallaVaultCyberAwereness.Data;

#nullable disable

namespace ValhallaVaultCyberAwereness.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240308093357_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ValhallaVaultCyberAwereness.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ValhallaVaultCyberAwereness.Data.Models.AnswerUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("IsAnswerCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("UserAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAnswers");
                });

            modelBuilder.Entity("ValhallaVaultCyberAwereness.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Categories")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Categories = "Att skydda sig mot bedrägerier"
                        },
                        new
                        {
                            CategoryId = 2,
                            Categories = "Cybersäkerhet för företag"
                        },
                        new
                        {
                            CategoryId = 3,
                            Categories = "Cyberspionage"
                        });
                });

            modelBuilder.Entity("ValhallaVaultCyberAwereness.Data.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("CorrectAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Explanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PossibleAnswers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Questions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SegmentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.HasIndex("SegmentId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            CorrectAnswer = "Ett potentiellt telefonbedrägeri",
                            Explanation = "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri.",
                            PossibleAnswers = "[\"Ett Legitimt f\\u00F6rs\\u00F6k fr\\u00E5n banken att skydda ditt konto\",\"En informationsinsamling f\\u00F6r en marknadsunders\\u00F6kning\",\"Ett potentiellt telefonbedr\\u00E4geri\"]",
                            Questions = "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att \"säkerställa din kontos säkerhet\" efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?",
                            SegmentId = 1,
                            Title = "Kreditkortsbedrägeri"
                        },
                        new
                        {
                            QuestionId = 2,
                            CorrectAnswer = "Ett romansbedrägeri",
                            Explanation = "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri.",
                            PossibleAnswers = "[\"En legitim beg\\u00E4ran om hj\\u00E4lp fr\\u00E5n en person i n\\u00F6d\",\"Ett romansbedr\\u00E4geri\",\"En tillf\\u00E4llig ekonomisk sv\\u00E5righet\"]",
                            Questions = "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?",
                            SegmentId = 1,
                            Title = "Romansbedrägeri"
                        },
                        new
                        {
                            QuestionId = 3,
                            CorrectAnswer = "Kreditkortsbedrägeri",
                            Explanation = "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri.",
                            PossibleAnswers = "[\"Ett misstag av kreditkortsf\\u00F6retaget\",\"Kreditkortsbedr\\u00E4geri\",\"Obeh\\u00F6riga k\\u00F6p av en familjemedlem\"]",
                            Questions = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?",
                            SegmentId = 1,
                            Title = "Telefonbedrägeri"
                        },
                        new
                        {
                            QuestionId = 4,
                            SegmentId = 2,
                            Title = "Bedrägerier i hemmet"
                        },
                        new
                        {
                            QuestionId = 5,
                            SegmentId = 2,
                            Title = "Identitetsstöld"
                        },
                        new
                        {
                            QuestionId = 6,
                            SegmentId = 2,
                            Title = "Nätfiske och bluffmejl"
                        },
                        new
                        {
                            QuestionId = 7,
                            SegmentId = 2,
                            Title = "Investeringsbedrägeri på nätet"
                        },
                        new
                        {
                            QuestionId = 8,
                            SegmentId = 3,
                            Title = "Abonnemangsfällor och falska fakturor"
                        },
                        new
                        {
                            QuestionId = 9,
                            SegmentId = 3,
                            Title = "Ransomware"
                        },
                        new
                        {
                            QuestionId = 10,
                            SegmentId = 3,
                            Title = "Statistik och förhållningssätt"
                        },
                        new
                        {
                            QuestionId = 11,
                            CorrectAnswer = "Utbildning i digital säkerhet för alla anställda",
                            Explanation = "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.",
                            PossibleAnswers = "[\"Utbildning i digital s\\u00E4kerhet f\\u00F6r alla anst\\u00E4llda\",\"Installera en starkare brandv\\u00E4gg\",\"Byta ut all IT-utrustning\"]",
                            Questions = "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?",
                            SegmentId = 4,
                            Title = "Digital säkerhet på företag"
                        },
                        new
                        {
                            QuestionId = 12,
                            CorrectAnswer = "Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder",
                            Explanation = "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.",
                            PossibleAnswers = "[\"Informera alla anv\\u00E4ndare om s\\u00E5rbarheten och rekommendera tempor\\u00E4ra skydds\\u00E5tg\\u00E4rder\",\"Ignorera problemet tills en patch kan utvecklas\",\"St\\u00E4nga ner tj\\u00E4nsten tillf\\u00E4lligt\"]",
                            Questions = "Inom företaget upptäckts det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?",
                            SegmentId = 4,
                            Title = "Risker och beredskap"
                        },
                        new
                        {
                            QuestionId = 13,
                            CorrectAnswer = "Organiserade cyberbrottsliga grupper",
                            Explanation = "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.",
                            PossibleAnswers = "[\"En enskild hackare med ett personligt vendetta\",\"En konkurrerande f\\u00F6retagsentitet\",\"Organiserade cyberbrottsliga grupper\"]",
                            Questions = "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?",
                            SegmentId = 4,
                            Title = "Aktörer inom cyberbrott"
                        },
                        new
                        {
                            QuestionId = 14,
                            CorrectAnswer = "Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst",
                            Explanation = "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.",
                            PossibleAnswers = "[\"\\u00C5terg\\u00E5 till kontorsarbete\",\"Inf\\u00F6ra striktare l\\u00F6senordspolicyer och tv\\u00E5faktorsautentisering f\\u00F6r fj\\u00E4rr\\u00E5tkomst\",\"F\\u00F6rbjuda anv\\u00E4ndning av personliga enheter f\\u00F6r arbete\"]",
                            Questions = "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?",
                            SegmentId = 4,
                            Title = "Ökad digital närvaro och distansarbete"
                        },
                        new
                        {
                            QuestionId = 15,
                            CorrectAnswer = "Ransomware",
                            Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.",
                            PossibleAnswers = "[\"Phishing\",\"Ransomware\",\"Spyware\"]",
                            Questions = "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?",
                            SegmentId = 4,
                            Title = "Cyberangrepp mot känsliga sektorer"
                        },
                        new
                        {
                            QuestionId = 16,
                            CorrectAnswer = "Ransomware",
                            Explanation = "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera företagets globala system.\r\nMaersk rapporterade att företaget led ekonomiska förluster på grund av NotPetya ransomware-angreppet som uppskattades till cirka 300 miljoner USD. Denna siffra reflekterar de omfattande kostnaderna för störningar i deras globala verksamheter, återställande av system och data, samt förlust av affärer under tiden systemen var nere. NotPetya-angreppet anses vara ett av de mest kostsamma cyberangreppen mot ett enskilt företag och tjänar som en kraftfull påminnelse om de potentiella konsekvenserna av cyberhot.",
                            PossibleAnswers = "[\"Spyware\",\"Ransomware\",\"Adware\"]",
                            Questions = "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?",
                            SegmentId = 4,
                            Title = "Cyberrånet mot Mersk"
                        },
                        new
                        {
                            QuestionId = 17,
                            SegmentId = 5,
                            Title = "Social engineering"
                        },
                        new
                        {
                            QuestionId = 18,
                            SegmentId = 5,
                            Title = "Nätfiske och skräppost"
                        },
                        new
                        {
                            QuestionId = 19,
                            SegmentId = 5,
                            Title = "Vishing"
                        },
                        new
                        {
                            QuestionId = 20,
                            SegmentId = 5,
                            Title = "Varning för vishing"
                        },
                        new
                        {
                            QuestionId = 21,
                            SegmentId = 5,
                            Title = "Identifiera VD-mejl"
                        },
                        new
                        {
                            QuestionId = 22,
                            SegmentId = 5,
                            Title = "Öneangrepp och presentkortsbluffar"
                        },
                        new
                        {
                            QuestionId = 23,
                            SegmentId = 6,
                            Title = "Virus, maskar och trojaner"
                        },
                        new
                        {
                            QuestionId = 24,
                            SegmentId = 6,
                            Title = "Så kan det gå till"
                        },
                        new
                        {
                            QuestionId = 25,
                            SegmentId = 6,
                            Title = "Nätverksintrång"
                        },
                        new
                        {
                            QuestionId = 26,
                            SegmentId = 6,
                            Title = "Dataintrång"
                        },
                        new
                        {
                            QuestionId = 27,
                            SegmentId = 6,
                            Title = "Hackad!"
                        },
                        new
                        {
                            QuestionId = 28,
                            SegmentId = 6,
                            Title = "Vägarna in"
                        },
                        new
                        {
                            QuestionId = 29,
                            SegmentId = 7,
                            Title = "Utpressningsvirus"
                        },
                        new
                        {
                            QuestionId = 30,
                            SegmentId = 7,
                            Title = "Attacker mot servrar"
                        },
                        new
                        {
                            QuestionId = 31,
                            SegmentId = 7,
                            Title = "Cyberangrepp i Norden"
                        },
                        new
                        {
                            QuestionId = 32,
                            SegmentId = 7,
                            Title = "It-brottslingarnas verktyg"
                        },
                        new
                        {
                            QuestionId = 33,
                            SegmentId = 7,
                            Title = "Mirai, Wannacry och fallet Düsseldorf"
                        },
                        new
                        {
                            QuestionId = 34,
                            SegmentId = 7,
                            Title = "De sårbara molnen"
                        },
                        new
                        {
                            QuestionId = 35,
                            CorrectAnswer = "Cyberspionage",
                            Explanation = "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande, typiskt för politiska, militära eller ekonomiska fördelar.",
                            PossibleAnswers = "[\"Cyberkriminalitet\",\"Cyberspionage\",\"Cyberterrorism\"]",
                            Questions = "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?",
                            SegmentId = 8,
                            Title = "Allmänt om cyberspionage"
                        },
                        new
                        {
                            QuestionId = 36,
                            CorrectAnswer = "Riktade cyberattacker",
                            Explanation = "Riktade cyberattacker som utnyttjar noll-dagars Zero-day sårbarheter är en avancerad metod för cyberspionage där angriparen specifikt riktar in sig på ett mål för att komma åt känslig information eller data genom att utnyttja tidigare okända sårbarheter i programvara.",
                            PossibleAnswers = "[\"Social ingenj\\u00F6rskonst\",\"Mass\\u00F6vervakning\",\"Riktade cyberattacker\"]",
                            Questions = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?",
                            SegmentId = 8,
                            Title = "Metoder för cyberspionage"
                        },
                        new
                        {
                            QuestionId = 37,
                            CorrectAnswer = "Säkerhetsskyddslagen",
                            Explanation = "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information från spioneri, sabotage, terroristbrott och andra säkerhetshot. Lagen ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.",
                            PossibleAnswers = "[\"GDPR\",\"S\\u00E4kerhetsskyddslagen\",\"IT-s\\u00E4kerhetslagen\"]",
                            Questions = "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?",
                            SegmentId = 8,
                            Title = "Säkerhetsskyddslagen"
                        },
                        new
                        {
                            QuestionId = 38,
                            CorrectAnswer = "Statssponsrade hackers",
                            Explanation = "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering för att genomföra cyberspionage, ofta riktat mot utländska intressen, organisationer eller regeringar för att få strategiska fördelar.",
                            PossibleAnswers = "[\"Oberoende hackare\",\"Aktivistgrupper\",\"Statssponsrade hackers\"]",
                            Questions = "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?",
                            SegmentId = 8,
                            Title = "Cyberspionagets aktörer"
                        },
                        new
                        {
                            QuestionId = 39,
                            SegmentId = 9,
                            Title = "Värvningsförsök"
                        },
                        new
                        {
                            QuestionId = 40,
                            SegmentId = 9,
                            Title = "Affärsspionage"
                        },
                        new
                        {
                            QuestionId = 41,
                            SegmentId = 9,
                            Title = "Påverkanskampanjer"
                        },
                        new
                        {
                            QuestionId = 42,
                            SegmentId = 10,
                            Title = "Svensk underrättelsetjänst och cyberförsvar"
                        },
                        new
                        {
                            QuestionId = 43,
                            SegmentId = 10,
                            Title = "Signalspaning, informationssäkerhet och 5G"
                        },
                        new
                        {
                            QuestionId = 44,
                            SegmentId = 10,
                            Title = "Samverkan mot cyberspionage"
                        });
                });

            modelBuilder.Entity("ValhallaVaultCyberAwereness.Data.Models.Segment", b =>
                {
                    b.Property<int>("SegmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SegmentId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SegmentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SegmentId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Segments");

                    b.HasData(
                        new
                        {
                            SegmentId = 1,
                            CategoryId = 1,
                            SegmentTitle = "Del 1"
                        },
                        new
                        {
                            SegmentId = 2,
                            CategoryId = 1,
                            SegmentTitle = "Del 2"
                        },
                        new
                        {
                            SegmentId = 3,
                            CategoryId = 1,
                            SegmentTitle = "Del 3"
                        },
                        new
                        {
                            SegmentId = 4,
                            CategoryId = 2,
                            SegmentTitle = "Del 1"
                        },
                        new
                        {
                            SegmentId = 5,
                            CategoryId = 2,
                            SegmentTitle = "Del 2"
                        },
                        new
                        {
                            SegmentId = 6,
                            CategoryId = 2,
                            SegmentTitle = "Del 3"
                        },
                        new
                        {
                            SegmentId = 7,
                            CategoryId = 2,
                            SegmentTitle = "Del 4"
                        },
                        new
                        {
                            SegmentId = 8,
                            CategoryId = 3,
                            SegmentTitle = "Del 1"
                        },
                        new
                        {
                            SegmentId = 9,
                            CategoryId = 3,
                            SegmentTitle = "Del 4"
                        },
                        new
                        {
                            SegmentId = 10,
                            CategoryId = 3,
                            SegmentTitle = "Del 4"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ValhallaVaultCyberAwereness.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ValhallaVaultCyberAwereness.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ValhallaVaultCyberAwereness.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ValhallaVaultCyberAwereness.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ValhallaVaultCyberAwereness.Data.Models.AnswerUser", b =>
                {
                    b.HasOne("ValhallaVaultCyberAwereness.Data.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ValhallaVaultCyberAwereness.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Question");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ValhallaVaultCyberAwereness.Data.Models.Question", b =>
                {
                    b.HasOne("ValhallaVaultCyberAwereness.Data.Models.Segment", "Segment")
                        .WithMany("Question")
                        .HasForeignKey("SegmentId");

                    b.Navigation("Segment");
                });

            modelBuilder.Entity("ValhallaVaultCyberAwereness.Data.Models.Segment", b =>
                {
                    b.HasOne("ValhallaVaultCyberAwereness.Data.Models.Category", "Category")
                        .WithMany("Segments")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ValhallaVaultCyberAwereness.Data.Models.Category", b =>
                {
                    b.Navigation("Segments");
                });

            modelBuilder.Entity("ValhallaVaultCyberAwereness.Data.Models.Segment", b =>
                {
                    b.Navigation("Question");
                });
#pragma warning restore 612, 618
        }
    }
}
