from django.db import models


# Creates model of University Campus
class UniversityCampus(models.Model):
    campus_name = models.CharField(verbose_name="Campus Name", max_length=60, default="", blank=False, null=False)
    state = models.CharField(max_length=2, default="", blank=False, null=False)
    campus_id = models.IntegerField(verbose_name="Campus ID", default="", blank=False, null=False)

    # Creates model manager
    object = models.Manager()

    # Displays the object output values in the form of a string
    def __str__(self):
        display_campus = '{0.campus_name} - {0.state}'
        return display_campus.format(self)

    # Removes added 's' that Django adds to the model name in the browser display
    class Meta:
        verbose_name_plural = "University Campus"