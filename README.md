# Introduction

This project is a bank-end only developer blog/Portfolio, for my H2 OOP project.
The Main method runs a string of hard coded methods to show that the methods work & how they work.

# Links
### Change Log Updates
[Version 1.](#Version_1.)
[Version 1.2.](#Version_1.2.)
[Version 1.3.](#Version_1.3.)
[Version 1.4.](#Version_1.4.)
[Version 1.5.](#Version_1.5.)
[Version 1.6.](#Version_1.6.)

## Methods used
### EntryDelete()
- Reads xml file with XDocument. 
- With XElement search threw xml file for specific ID.
- If XElement parameter is not null find XElement "Active" element, & change its value to "False"

### EntryUpdate()
- Reads xml file with XDocument. 
- With XElement search threw xml file for specific ID.
- If XElement parameter is not null find XElement (User-In-Put-Element) element, & change its value to "User-In-Put-Chang".

### IDCatcher()
- Reads xml file with XDocument. 
- Makes a list with every descending element of Blog Post, Reference & Framework Review.
- Search for ID attribute of all the entry's & add them to a list of ID's.
- Set prop ID value to ID's list max value plus one.

### SaveEntry()
- Loads xml file with XmlDocument.
- Create the corresponding nodes for the necessary data needed for filling out specific entry.
- Save new nodes & attributes to xml file.

###  ReadFileToCloudLists
- Asynchronously calls the Tag, Image, File & Language read method.
- The read method, opens the file with XDocument.
- With XDocument Reads the descending element's of Tag, Image, File & Language.
- Then runs a foreach to fills out each of there respective lists.

# Change log
All notable changes to this project will be documented in this file.

# [Unreleased]
## Version 1.6. - ??-??-??
### Changed
- [ ] Read method from Tag, Image, File & Language change so they don't add deleted entrys to there list

## Version 1.5. - 31-08-21
### Added
- [x] Add method for deleting entry
- [x] Add method for updating entry 

### Changed
- [x] Read xml file asynchronously

## Version 1.4. - 30-08-21
### Added
- [x] Method for writing FrameworkReview to xml file
- [x] Method for writing Reference to xml file
- [x] Adding ID to entrys
- [x] Method for reading only entry id  

## Version 1.3. - 27-08-21
### Added
- [x]  Add EntryRepo, BlogPostRepo, FrameworkReview & Reference Class
- [x] Add method for writing BlogPostto xml file
- [x] Add method for reading xml file on TagCloud, ImageCloud, LanguageCloud & FileCloud
- [x] Add method for adding Tag, Image, File & Language to there respective lists
- [x] Add method for adding Tag, Image, File & Language to the Clouds lists



## Version 1.2. - 25-08-21
### Added
- [x] Add SaveText() Method for writing created Tag, Image, Language &/Or File.

### Changed
- [x] Properties on Tag, Image, Language & File to match new methods.
- [x] Entry properties to use Tag, Image, Language & File cloud instead.
- [x] Change Entry constructor to  add option for Image & File.

## Version 1. - 24-08-2021
### Added
- [x] Add properties to tag & tag cloud
- [x] Add properties on language & language cloud
- [x] Add properties to file & file cloud 
- [x] Add properties to image & image cloud
- [x] Add reference Class/constructer
- [x] Add framework review Class/constructer
- [x] Add blog post Class/constructer
- [x] Add properties to Entry
- [x] Add properties & constructor for contact class


