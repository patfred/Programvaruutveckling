from django.db import models
from kyhTest.content.models import Company
from kyhTest.content.models import Tag
from kyhTest.content.models import Program

class Contact(models.Model):
	
	first_name = models.CharField(max_length = 45)
	last_name = models.CharField(max_length = 45)
	title = models.CharField(max_length = 45)
	phone = models.CharField(max_length = 45)
	email = models.CharField(max_length = 45)
	description = models.CharField(max_length = 45)
	company = models.ForeignKey('Company')
	tag = models.ManyToManyField('Tag')
	program = models.ManyToManyField('Program')
