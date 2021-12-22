Feature: WebAPI

Scenario: Upload

	Given I have file to upload
	When I send request to upload 
	Then I get uploaded file

Scenario: Get_metadata

	Given I have file to get metadata
	When I send request to get metadata
	Then I get metadata 

Scenario: Delete

	Given I have file to delete
	When I send request to delete
	Then I responce that file delited 

