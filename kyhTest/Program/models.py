from django import models
from kyhTest.content.models import Tag
from kyhTest.content.models import Company
from kyhTest.content.models import Contact

class Program(models.Model):

	name = models.CharField(max_length = 45)
	short_name = models.CharField(max_length = 5)
	start_date = models.DateField()
	end_date = models.DateField()
	city = models.CharField(max_length = 45)
	description = models.TextField()
	in_charge = models.CharField(max_length = 45)
	tag = models.ManyToManyField('Tag')
	company = models.ManyToManyField('Company')
	contact = models.ManyToManyField('Contact')
