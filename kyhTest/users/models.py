from django.db import models

class User(models.Model):
	email = models.CharField(max_length = 45)
	password = models.CharField(max_length = 45)
	admin = models.BooleanField()
	salt = models.CharField(max_length = 45)
	
	