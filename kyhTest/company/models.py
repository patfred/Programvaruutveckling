from django.db import models

class Company(models.Model):
	name = models.CharField(max_length = 45)
	address = models.CharField(max_length = 45)
	phone = models.CharField(max_length = 45)
	email = models.CharField(max_length = 45)
	website = models.CharField(max_length = 45)
	description = models.CharField(max_lenght = 45)
	tags = models.ForeignKey('Tag')
	
	