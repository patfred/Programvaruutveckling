from django.db import models
from kyhTest.content.models import Company
from kyhTest.content.models import Contact
from kyhTest.content.models import Program

class Tag(models.Model):
	name = models.CharField(max_length = 45)
	company = models.ManyToManyField('Company')
	contact = models.ManyToManyField('Contact')
	program = models.ManyToManyField('Program')
