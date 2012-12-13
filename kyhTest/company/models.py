from django.db import models
from kyhTest.content.models import Tag
from kyhTest.content.models import Program

class Company(models.Model):
	name = models.CharField(max_length = 45)
	address = models.CharField(max_length = 45)
	phone = models.CharField(max_length = 45)
	email = models.CharField(max_length = 45)
	website = models.CharField(max_length = 45)
	description = models.CharField(max_lenght = 45)
	tag = models.ManyToManyField('Tag')
	program = models.ManyToManyField('Program')
	
	