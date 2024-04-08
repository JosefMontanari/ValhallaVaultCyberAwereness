using ValhallaVaultCyberAwereness.Data.Models;

namespace UnitTest.Josef
{
	public class JosefsTestSegment
	{



		[Fact]
		public async void StartSegment()
		{

			var segments = new List<Segment>
		{
			new Segment { SegmentId = 0 },
			new Segment { SegmentId = 1 },
			new Segment { SegmentId = 3 },
		};



		}
	}

	public class TestSegment
	{
		List<Segment> segments;
		string userId;
		List<AnswerUser>? userAnswers;


		public TestSegment(List<Segment> segments)
		{
			this.segments = segments;
		}

		public async Task<bool> StartSegment(int id)
		{
			if (segments != null)
			{
				if (id == segments.First().SegmentId)
				{
					return true;
				}

				// Kolla tidigare segments
				var previousSegmentId = segments
				.OrderBy(s => s.SegmentId)
				.FirstOrDefault(s => s.SegmentId >= id - 1)?.SegmentId ?? 0;

				var previousSegment = segments.FirstOrDefault(s => s.SegmentId == previousSegmentId);

				if (previousSegment != null)
				{
					//Kolla om förra segmentet var mer än 80%  korrekt
					double result = previousSegment.CalculateCorrectAnswers(userAnswers, userId);
					if (result >= 80)
					{
						return true;
					}
					else
					{
						return false;
					}

				}
				else
				{
					return true;
				}

			}
			else
			{
				return false;
			}
		}
	}
}
