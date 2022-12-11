from django import forms
from .models import ArticleImage, Category

class CategoryForm(forms.ModelForm):
  slug = forms.SlugField()

  class Meta:
    model = Category
    fields = '__all__'

class ArticleImageForm(forms.ModelForm):
  image = forms.ImageField(widget=forms.ClearableFileInput(attrs={'multiple':True}))

  class Meta:
    model = ArticleImage
    fields = '__all__'
