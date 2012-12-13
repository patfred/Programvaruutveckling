from django import models

class Program(models.Model):

	name = models.CharField(max_length = 45)
	short_name = models.CharField(max_length = 5)
	start_date = models.DateField()
	end_date = models.DateField()
	city = models.CharField(max_length = 45)
	description = models.TextField()
	in_charge = models.CharField(max_length = 45)
	tags = models.ManyToManyField('Tag')
