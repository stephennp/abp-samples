﻿{{my_model = model}}
{{subject_property = model.report.subject_property}}
Hello {{my_model.name}} :)
Report: {{my_model.report.name}}
Subject property: {{ my_model.report.subject_property.name}}
Address line 1: {{my_model.report.subject_property.street_address_line1}}

<?xml version="1.0" ?>
<text>{{my_model.name | html.strip}}</text>
<valuation _name="{{subject_property.name}}" _city="{{subject_property.city}}" _state="{{subject_property.state}}">
</valuation>