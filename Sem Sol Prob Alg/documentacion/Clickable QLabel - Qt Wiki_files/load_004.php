var mediaWikiLoadStart=(new Date()).getTime();function isCompatible(ua){if(ua===undefined){ua=navigator.userAgent;}return!((ua.indexOf('MSIE')!==-1&&parseFloat(ua.split('MSIE')[1])<6)||(ua.indexOf('Firefox/')!==-1&&parseFloat(ua.split('Firefox/')[1])<3)||ua.match(/BlackBerry[^\/]*\/[1-5]\./)||ua.match(/webOS\/1\.[0-4]/)||ua.match(/PlayStation/i)||ua.match(/SymbianOS|Series60/)||ua.match(/NetFront/)||ua.match(/Opera Mini/)||ua.match(/S40OviBrowser/)||(ua.match(/Glass/)&&ua.match(/Android/)));}var startUp=function(){mw.config=new mw.Map(true);mw.loader.addSource({"local":{"loadScript":"/load.php","apiScript":"/api.php"}});mw.loader.register([["site","1471504626",[],"site"],["noscript","1471504626",[],"noscript"],["startup","1473848676",[],"startup"],["filepage","1471504626"],["user.groups","1471504626",[],"user"],["user","1471504626",[],"user"],["user.cssprefs","1471504626",["mediawiki.user"],"private"],["user.options","1471504626",[],"private"],["user.tokens","1471504626",[],"private"],
["mediawiki.language.data","1471504626",["mediawiki.language.init"]],["mediawiki.skinning.elements","1471504627"],["mediawiki.skinning.content","1471504627"],["mediawiki.skinning.interface","1471504627"],["skins.cologneblue","1471504627"],["skins.modern","1471504627"],["skins.vector.styles","1471504627"],["skins.monobook.styles","1471504627"],["skins.vector.js","1471504627",["jquery.throttle-debounce"]],["skins.vector.collapsibleNav","1473834818",["jquery.client","jquery.cookie","jquery.tabIndex"]],["jquery","1471504627"],["jquery.appear","1471504627"],["jquery.arrowSteps","1471504627"],["jquery.async","1471504627"],["jquery.autoEllipsis","1471504627",["jquery.highlightText"]],["jquery.badge","1471504627",["mediawiki.language"]],["jquery.byteLength","1471504627"],["jquery.byteLimit","1471504627",["jquery.byteLength"]],["jquery.checkboxShiftClick","1471504627"],["jquery.chosen","1471504627"],["jquery.client","1471504627"],["jquery.color","1471504627",["jquery.colorUtil"]],[
"jquery.colorUtil","1471504627"],["jquery.cookie","1471504627"],["jquery.delayedBind","1471504627"],["jquery.expandableField","1471504627"],["jquery.farbtastic","1471504627",["jquery.colorUtil"]],["jquery.footHovzer","1471504627"],["jquery.form","1471504627"],["jquery.fullscreen","1471504627"],["jquery.getAttrs","1471504627"],["jquery.hidpi","1471504627"],["jquery.highlightText","1471504627",["jquery.mwExtension"]],["jquery.hoverIntent","1471504627"],["jquery.json","1471504627"],["jquery.localize","1471504627"],["jquery.makeCollapsible","1473834818"],["jquery.mockjax","1471504627"],["jquery.mw-jump","1471504627"],["jquery.mwExtension","1471504627"],["jquery.placeholder","1471504627"],["jquery.qunit","1471504627"],["jquery.qunit.completenessTest","1471504627",["jquery.qunit"]],["jquery.spinner","1471504627"],["jquery.jStorage","1471504627",["jquery.json"]],["jquery.suggestions","1471504627",["jquery.highlightText"]],["jquery.tabIndex","1471504627"],["jquery.tablesorter","1473843671",[
"jquery.mwExtension","mediawiki.language.months"]],["jquery.textSelection","1471504627",["jquery.client"]],["jquery.throttle-debounce","1471504627"],["jquery.validate","1471504627"],["jquery.xmldom","1471504627"],["jquery.tipsy","1471504627"],["jquery.ui.core","1471504627",[],"jquery.ui"],["jquery.ui.widget","1471504627",[],"jquery.ui"],["jquery.ui.mouse","1471504627",["jquery.ui.widget"],"jquery.ui"],["jquery.ui.position","1471504627",[],"jquery.ui"],["jquery.ui.draggable","1471504627",["jquery.ui.core","jquery.ui.mouse","jquery.ui.widget"],"jquery.ui"],["jquery.ui.droppable","1471504627",["jquery.ui.core","jquery.ui.draggable","jquery.ui.mouse","jquery.ui.widget"],"jquery.ui"],["jquery.ui.resizable","1471504627",["jquery.ui.core","jquery.ui.mouse","jquery.ui.widget"],"jquery.ui"],["jquery.ui.selectable","1471504627",["jquery.ui.core","jquery.ui.mouse","jquery.ui.widget"],"jquery.ui"],["jquery.ui.sortable","1471504627",["jquery.ui.core","jquery.ui.mouse","jquery.ui.widget"],
"jquery.ui"],["jquery.ui.accordion","1471504627",["jquery.ui.core","jquery.ui.widget"],"jquery.ui"],["jquery.ui.autocomplete","1471504627",["jquery.ui.core","jquery.ui.position","jquery.ui.widget"],"jquery.ui"],["jquery.ui.button","1471504627",["jquery.ui.core","jquery.ui.widget"],"jquery.ui"],["jquery.ui.datepicker","1471504627",["jquery.ui.core"],"jquery.ui"],["jquery.ui.dialog","1471504627",["jquery.ui.button","jquery.ui.core","jquery.ui.draggable","jquery.ui.mouse","jquery.ui.position","jquery.ui.resizable","jquery.ui.widget"],"jquery.ui"],["jquery.ui.progressbar","1471504627",["jquery.ui.core","jquery.ui.widget"],"jquery.ui"],["jquery.ui.slider","1471504627",["jquery.ui.core","jquery.ui.mouse","jquery.ui.widget"],"jquery.ui"],["jquery.ui.tabs","1471504627",["jquery.ui.core","jquery.ui.widget"],"jquery.ui"],["jquery.effects.core","1471504627",[],"jquery.ui"],["jquery.effects.blind","1471504627",["jquery.effects.core"],"jquery.ui"],["jquery.effects.bounce","1471504627",[
"jquery.effects.core"],"jquery.ui"],["jquery.effects.clip","1471504627",["jquery.effects.core"],"jquery.ui"],["jquery.effects.drop","1471504627",["jquery.effects.core"],"jquery.ui"],["jquery.effects.explode","1471504627",["jquery.effects.core"],"jquery.ui"],["jquery.effects.fade","1471504627",["jquery.effects.core"],"jquery.ui"],["jquery.effects.fold","1471504627",["jquery.effects.core"],"jquery.ui"],["jquery.effects.highlight","1471504627",["jquery.effects.core"],"jquery.ui"],["jquery.effects.pulsate","1471504627",["jquery.effects.core"],"jquery.ui"],["jquery.effects.scale","1471504627",["jquery.effects.core"],"jquery.ui"],["jquery.effects.shake","1471504627",["jquery.effects.core"],"jquery.ui"],["jquery.effects.slide","1471504627",["jquery.effects.core"],"jquery.ui"],["jquery.effects.transfer","1471504627",["jquery.effects.core"],"jquery.ui"],["moment","1471504627"],["mediawiki","1471504627"],["mediawiki.api","1471504627",["mediawiki.util"]],["mediawiki.api.category","1471504627",[
"mediawiki.Title","mediawiki.api"]],["mediawiki.api.edit","1471504627",["mediawiki.Title","mediawiki.api","user.tokens"]],["mediawiki.api.login","1471504627",["mediawiki.api"]],["mediawiki.api.parse","1471504627",["mediawiki.api"]],["mediawiki.api.watch","1471504627",["mediawiki.api","user.tokens"]],["mediawiki.debug","1471504627",["jquery.footHovzer","jquery.tipsy"]],["mediawiki.debug.init","1471504627",["mediawiki.debug"]],["mediawiki.feedback","1471504627",["jquery.ui.dialog","mediawiki.Title","mediawiki.api.edit","mediawiki.jqueryMsg"]],["mediawiki.hidpi","1471504627",["jquery.hidpi"]],["mediawiki.hlist","1471504627",["jquery.client"]],["mediawiki.htmlform","1473837362"],["mediawiki.icon","1471504627"],["mediawiki.inspect","1471504627",["jquery.byteLength","jquery.json"]],["mediawiki.notification","1471504627",["mediawiki.page.startup"]],["mediawiki.notify","1471504627"],["mediawiki.searchSuggest","1473834818",["jquery.client","jquery.placeholder","jquery.suggestions",
"mediawiki.api"]],["mediawiki.Title","1471504627",["jquery.byteLength","mediawiki.util"]],["mediawiki.toc","1473834817",["jquery.cookie"]],["mediawiki.Uri","1471504627"],["mediawiki.user","1471504627",["jquery.cookie","mediawiki.api","user.options","user.tokens"]],["mediawiki.util","1471504627",["jquery.client","jquery.mwExtension","mediawiki.notify","mediawiki.toc"]],["mediawiki.action.edit","1471504627",["jquery.byteLimit","jquery.textSelection","mediawiki.action.edit.styles"]],["mediawiki.action.edit.styles","1471504627"],["mediawiki.action.edit.collapsibleFooter","1471504627",["jquery.cookie","jquery.makeCollapsible","mediawiki.icon"]],["mediawiki.action.edit.preview","1471504627",["jquery.form","jquery.spinner","mediawiki.action.history.diff"]],["mediawiki.action.history","1471504627",[],"mediawiki.action.history"],["mediawiki.action.history.diff","1471504627",[],"mediawiki.action.history"],["mediawiki.action.view.dblClickEdit","1471504627",["mediawiki.page.startup",
"mediawiki.util"]],["mediawiki.action.view.metadata","1471504627"],["mediawiki.action.view.postEdit","1473834818",["jquery.cookie","mediawiki.jqueryMsg"]],["mediawiki.action.view.redirectToFragment","1471504627",["jquery.client"]],["mediawiki.action.view.rightClickEdit","1471504627"],["mediawiki.action.edit.editWarning","1473838423",["mediawiki.jqueryMsg"]],["mediawiki.action.watch.ajax","1471504626",["mediawiki.page.watch.ajax"]],["mediawiki.language","1471504627",["mediawiki.cldr","mediawiki.language.data"]],["mediawiki.cldr","1471504627",["mediawiki.libs.pluralruleparser"]],["mediawiki.libs.pluralruleparser","1471504627"],["mediawiki.language.init","1471504627"],["mediawiki.jqueryMsg","1471504627",["mediawiki.language","mediawiki.util"]],["mediawiki.language.months","1473843671",["mediawiki.language"]],["mediawiki.libs.jpegmeta","1471504627"],["mediawiki.page.gallery","1471504627"],["mediawiki.page.ready","1471504627",["jquery.checkboxShiftClick","jquery.makeCollapsible",
"jquery.mw-jump","jquery.placeholder","mediawiki.util"]],["mediawiki.page.startup","1471504627",["mediawiki.util"]],["mediawiki.page.patrol.ajax","1473848676",["jquery.spinner","mediawiki.Title","mediawiki.api","mediawiki.notify","mediawiki.page.startup","mediawiki.util","user.tokens"]],["mediawiki.page.watch.ajax","1473836270",["jquery.mwExtension","mediawiki.api.watch","mediawiki.notify","mediawiki.page.startup","mediawiki.util"]],["mediawiki.page.image.pagination","1471504627",["jquery.spinner","mediawiki.Uri","mediawiki.util"]],["mediawiki.special","1471504627"],["mediawiki.special.block","1471504627",["mediawiki.util"]],["mediawiki.special.changeemail","1471504627",["mediawiki.util"]],["mediawiki.special.changeslist","1471504627"],["mediawiki.special.changeslist.legend","1471504627"],["mediawiki.special.changeslist.legend.js","1471504627",["jquery.cookie","jquery.makeCollapsible"]],["mediawiki.special.changeslist.enhanced","1471504627"],["mediawiki.special.movePage","1471504627",[
"jquery.byteLimit"]],["mediawiki.special.pagesWithProp","1471504627"],["mediawiki.special.preferences","1473837360",["mediawiki.language"]],["mediawiki.special.recentchanges","1471504627",["mediawiki.special"]],["mediawiki.special.search","1473835236"],["mediawiki.special.undelete","1471504627"],["mediawiki.special.upload","1471504627",["mediawiki.libs.jpegmeta","mediawiki.util"]],["mediawiki.special.userlogin.common.styles","1471504627"],["mediawiki.special.userlogin.signup.styles","1471504627"],["mediawiki.special.userlogin.login.styles","1471504627"],["mediawiki.special.userlogin.common.js","1471504627"],["mediawiki.special.userlogin.signup.js","1471504627",["jquery.throttle-debounce","mediawiki.api","mediawiki.jqueryMsg"]],["mediawiki.special.javaScriptTest","1471504627",["mediawiki.Uri"]],["mediawiki.special.version","1471504627"],["mediawiki.legacy.ajax","1471504627",["mediawiki.legacy.wikibits","mediawiki.util"]],["mediawiki.legacy.commonPrint","1471504627"],[
"mediawiki.legacy.config","1471504627",["mediawiki.legacy.wikibits"]],["mediawiki.legacy.protect","1471504627",["jquery.byteLimit"]],["mediawiki.legacy.shared","1471504627"],["mediawiki.legacy.oldshared","1471504627"],["mediawiki.legacy.upload","1471504627",["jquery.spinner","mediawiki.Title","mediawiki.api","mediawiki.util"]],["mediawiki.legacy.wikibits","1471504627",["mediawiki.util"]],["mediawiki.ui","1471504627"],["mediawiki.ui.button","1471504627"],["oojs","1471504627"],["oojs-ui","1471504627",["oojs"]],["ext.nuke","1471504626"],["ext.geshi.local","1471504626"],["jquery.wikiEditor","1473838422",["jquery.client","jquery.textSelection"],"ext.wikiEditor"],["jquery.wikiEditor.dialogs","1471504626",["jquery.tabIndex","jquery.ui.button","jquery.ui.dialog","jquery.ui.draggable","jquery.ui.resizable","jquery.wikiEditor","jquery.wikiEditor.toolbar"],"ext.wikiEditor"],["jquery.wikiEditor.dialogs.config","1473838422",["jquery.suggestions","jquery.wikiEditor","jquery.wikiEditor.dialogs",
"jquery.wikiEditor.toolbar.i18n","mediawiki.Title","mediawiki.jqueryMsg"],"ext.wikiEditor"],["jquery.wikiEditor.preview","1471504626",["jquery.wikiEditor"],"ext.wikiEditor"],["jquery.wikiEditor.previewDialog","1471504626",["jquery.wikiEditor","jquery.wikiEditor.dialogs"],"ext.wikiEditor"],["jquery.wikiEditor.publish","1471504626",["jquery.wikiEditor","jquery.wikiEditor.dialogs"],"ext.wikiEditor"],["jquery.wikiEditor.toolbar","1471504626",["jquery.wikiEditor","jquery.wikiEditor.toolbar.i18n"],"ext.wikiEditor"],["jquery.wikiEditor.toolbar.config","1471504626",["jquery.async","jquery.cookie","jquery.wikiEditor","jquery.wikiEditor.toolbar","jquery.wikiEditor.toolbar.i18n"],"ext.wikiEditor"],["jquery.wikiEditor.toolbar.i18n","1471504626",[],"ext.wikiEditor"],["ext.wikiEditor","1471504626",["jquery.wikiEditor"],"ext.wikiEditor"],["ext.wikiEditor.dialogs","1471504626",["ext.wikiEditor","ext.wikiEditor.toolbar","jquery.wikiEditor.dialogs","jquery.wikiEditor.dialogs.config"],"ext.wikiEditor"],[
"ext.wikiEditor.preview","1473838422",["ext.wikiEditor","jquery.wikiEditor.preview"],"ext.wikiEditor"],["ext.wikiEditor.previewDialog","1471504626",["ext.wikiEditor","jquery.wikiEditor.previewDialog"],"ext.wikiEditor"],["ext.wikiEditor.publish","1473838422",["ext.wikiEditor","jquery.wikiEditor.publish"],"ext.wikiEditor"],["ext.wikiEditor.tests.toolbar","1471504626",["ext.wikiEditor.toolbar"],"ext.wikiEditor"],["ext.wikiEditor.toolbar","1471504626",["ext.wikiEditor","jquery.wikiEditor.toolbar","jquery.wikiEditor.toolbar.config"],"ext.wikiEditor"],["ext.wikiEditor.toolbar.hideSig","1471504626",[],"ext.wikiEditor"],["mediawiki.api.titleblacklist","1471504626",["mediawiki.api"]],["ext.cite","1473834865"],["ext.cite.popups","1471504626",["jquery.tooltip"]],["jquery.tooltip","1471504626"],["ext.rtlcite","1471504626"],["ext.moderation","1471504626"],["ext.moderation.edit","1471504626"],["ext.moderation.notify","1473847386",["mediawiki.action.view.postEdit","mediawiki.jqueryMsg"]]]);mw.config.
set({"wgLoadScript":"/load.php","debug":false,"skin":"vector","stylepath":"/skins","wgUrlProtocols":"http\\:\\/\\/|https\\:\\/\\/|ftp\\:\\/\\/|ftps\\:\\/\\/|ssh\\:\\/\\/|sftp\\:\\/\\/|irc\\:\\/\\/|ircs\\:\\/\\/|xmpp\\:|sip\\:|sips\\:|gopher\\:\\/\\/|telnet\\:\\/\\/|nntp\\:\\/\\/|worldwind\\:\\/\\/|mailto\\:|tel\\:|sms\\:|news\\:|svn\\:\\/\\/|git\\:\\/\\/|mms\\:\\/\\/|bitcoin\\:|magnet\\:|urn\\:|geo\\:|\\/\\/","wgArticlePath":"/$1","wgScriptPath":"","wgScriptExtension":".php","wgScript":"/index.php","wgSearchType":null,"wgVariantArticlePath":false,"wgActionPaths":{},"wgServer":"//wiki.qt.io","wgUserLanguage":"en","wgContentLanguage":"en","wgVersion":"1.23.13","wgEnableAPI":true,"wgEnableWriteAPI":true,"wgMainPageTitle":"Main","wgFormattedNamespaces":{"-2":"Media","-1":"Special","0":"","1":"Talk","2":"User","3":"User talk","4":"Qt Wiki","5":"Qt Wiki talk","6":"File","7":"File talk","8":"MediaWiki","9":"MediaWiki talk","10":"Template","11":"Template talk","12":"Help","13":"Help talk","14"
:"Category","15":"Category talk","500":"KnowledgeBase","501":"KnowledgeBase talk","700":"QtWS","701":"QtWS talk","3600":"Qt Automotive Suite","3601":"Qt Automotive Suite talk"},"wgNamespaceIds":{"media":-2,"special":-1,"":0,"talk":1,"user":2,"user_talk":3,"qt_wiki":4,"qt_wiki_talk":5,"file":6,"file_talk":7,"mediawiki":8,"mediawiki_talk":9,"template":10,"template_talk":11,"help":12,"help_talk":13,"category":14,"category_talk":15,"knowledgebase":500,"knowledgebase_talk":501,"qtws":700,"qtws_talk":701,"qt_automotive_suite":3600,"qt_automotive_suite_talk":3601,"image":6,"image_talk":7,"project":4,"project_talk":5},"wgContentNamespaces":[0],"wgSiteName":"Qt Wiki","wgFileExtensions":["png","gif","jpg","jpeg"],"wgDBname":"heroku_app_db","wgFileCanRotate":true,"wgAvailableSkins":{"cologneblue":"CologneBlue","vector":"Vector","monobook":"MonoBook","modern":"Modern"},"wgExtensionAssetsPath":"/extensions","wgCookiePrefix":"heroku_app_db","wgResourceLoaderMaxQueryLength":-1,
"wgCaseSensitiveNamespaces":[],"wgLegalTitleChars":" %!\"$\u0026'()*,\\-./0-9:;=?@A-Z\\\\\\^_`a-z~+\\u0080-\\uFFFF","wgResourceLoaderStorageVersion":1,"wgResourceLoaderStorageEnabled":false,"wgWikiEditorMagicWords":{"redirect":"#REDIRECT","img_right":"right","img_left":"left","img_none":"none","img_center":"center","img_thumbnail":"thumbnail","img_framed":"framed","img_frameless":"frameless"}});};if(isCompatible()){document.write("\u003Cscript src=\"/load.php?debug=false\u0026amp;lang=en\u0026amp;modules=jquery%2Cmediawiki\u0026amp;only=scripts\u0026amp;skin=vector\u0026amp;version=20160818T071707Z\"\u003E\u003C/script\u003E");};
/* cache key: heroku_app_db:resourceloader:filter:minify-js:7:05456b7c77e3abe5f7c3e4874c70a485 */