-- このluaスクリプトは、EA_007_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_007)
	Camera002 = SetTemplate("Actor002",150,CharaPos110071_05_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_002)
	Camera004 = SetTemplate("Actor004",-190,CharaPos110071_05_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_004)
	Camera005 = SetTemplate("Actor005",-150,CharaPos110071_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_003)
	Camera007 = SetTemplate("Actor007",-90,CharaPos110071_05_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_006)
	Camera008 = SetTemplate("Actor008",-90,CharaPos110071_05_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_008)
	Camera009 = SetTemplate("Actor009",-90,CharaPos110071_05_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_008)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
-- ▼直接出力
load_image("101050210", "content_still_10105021_image", "101050210_StillImage")
show_image("101050210", 0.0, 0.0, 0.0,true,false)
set_position_image(150,0)
set_scale_image(1.1,1.1)
scale_to_image(0.83,0.83,8,2)
move_to_image(0,0,8,2)
load_image("104000220", "content_still_10400022_image", "104000220_StillImage") 
load_image("104000230", "content_still_10400023_image", "104000230_StillImage") 
load_image("104000240", "content_still_10400024_image", "104000240_StillImage") 
load_image("104000260", "content_still_10400026_image", "104000260_StillImage") 
load_image("104000270", "content_still_10400027_image", "104000270_StillImage") 
CameraEX = set_camera({-16.75,2.052,6.2,9.195,38.009,1,22})
set_camera_nearclip(CameraEX,2.5)
lookoj = create_object("kara")
set_pos_object(lookoj,-14.65,0.982,9.26)
-- ▲直接出力
-- ▼直接出力
Kylookat = get_object("m071")
-- ▲直接出力
-- ▼直接出力
load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
-- ▲直接出力
-- ▼直接出力
INIT_CHRPOS(Actor007,{-9.83,0.128,9.37,-90},false)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
INIT_CHRPOS(Actor008,{-9.8,0.128,8.54,-90},false)
Hide(Actor008)
INIT_CHRPOS(Actor009,{-9.28,0.128,10.79,-90},false)
Hide(Actor009)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(STILL_SWITCH_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0008")
-- ▲直接出力

	--★★マルイル★★:この時期、プレゼントのお悩み…ありますよね！<br>そんなときはお任せください！！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310004")

-- ▼直接出力
PlayPartVoiceDirect("マルイル","0036")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★マルイル★★:お呼びいただき光栄です！<br>出張マルイル青空商店、開・店・です！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310006")

-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0047")
-- ▲直接出力

	--★★カイル★★:す、すっごぉーい！！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0310007")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0045")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:なんて品揃えだ…言葉では表せないほど<br>とんでもない品々が目の前に並んでるぜ…！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_007_0310008")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0034")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:これは…迷いますね～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310009")


	--★★マルイル★★:降誕祭に向けてプレゼント需要が激増中！<br>仕入れはいつも以上に力を入れていますよお！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310010")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0027")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:こんなに大量に持ってきてもらっちゃって…<br>重かったんじゃないの…？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_007_0310011")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME+STILL_PASSIVE_AFTER)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0010")
-- ▲直接出力

	--★★マルイル★★:
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310012")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★マルイル★★:ぼくとしてもカイルくんのご両親には<br>仲良くしていただいていますし！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0004")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★カイル★★:いつもおせわになってます、マルイルさん<br>景気はどう？
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0310015")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★マルイル★★:景気は上々！ご無沙汰してますね、カイルくん！<br>きみの役に立てるなら嬉しいですよ！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0009")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★マルイル★★:それに、ほかの誰でもない<br>ノワールさんの頼みなら喜んで来ますよ！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
turn_lookat( Actor006,Actor003, 0.3)
wait_time(0.3)
PlayActionDirect(Actor006,"to  Std_Talk")
PlayPartVoiceDirect("子供_男1","0002")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★カイル★★:ねえねえ、クラリスお姉ちゃん！<br>これ！これどうかなあ！？
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0310018")

-- ▼直接出力
ShowImageItem("104000270")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0028")
-- ▲直接出力

	--★★クラリス★★:え、えーっと、これは──…？
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310019")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0010")
-- ▲直接出力

	--★★マルイル★★:見る目がありますね！これはカレドニア土産！！<br>竜が巻きついた剣のフィギュアです！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310020")

-- ▼直接出力
HideImageItem()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0026")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★カイル★★:竜が剣に巻きついてる！！<br>かっこいい！！こんなの見たことない！！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0310021")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0047")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:剣に竜が巻きついてる！！<br>かっけえ！！なんか心躍るぜ！！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_007_0310022")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0047")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ノワール★★:かっこいい…！なんとも言えない魅力があるな<br>竜が巻きついた剣は…！
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_007_0310023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0019")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラグネル★★:ええ…男子ってこういうのが好きなの？<br>クラリスちゃん、これ…どう？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_007_0310024")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0033")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クラリス★★:りゅ、竜が巻きついた剣のフィギュアを<br>ご両親へのプレゼントにするのは、さすがに…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310025")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
turn_lookat( Actor006,Actor001, 0)
PlayPartVoiceDirect("マルイル","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★マルイル★★:ではコチラ、港町サンダーンの隠れ名物<br>激辛チップス『カラクテウマイ』！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310026")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
ShowImageItem("104000220")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0012")
-- ▲直接出力

	--★★ガウェイン★★:おお！コレ買うぜ！<br>見るからにB級！アーサー様好きそうだし！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_007_0310027")

-- ▼直接出力
HideImageItem()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0033")
-- ▲直接出力

	--★★ラグネル★★:ガウェイン、あんた趣旨理解してる？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_007_0310028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
change_face(Actor002,"Normal")
PlayPartVoiceDirect("マルイル","0007")
-- ▲直接出力

	--★★マルイル★★:ラグネルさんにはコチラがオススメ！<br>絶版本『貴方はどうにか生き縫いて』
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310029")

-- ▼直接出力
ShowImageItem("104000230")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0028")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:ええっ！？伝説のぬいぐるみ職人！<br>シュパリー・シュパンパンの著書だ！買います！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_007_0310030")

-- ▼直接出力
HideImageItem()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
lookat_delay_weight(Actor003, 0.8,0.03,0.5,0.2,1.0)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.8)
PlayPartVoiceDirect("クラリス","0015")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310031")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0019")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★マルイル★★:え？ああ、コレですか<br>コレはもう商品としては出してないのですが…
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310032")

	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Surprise")

	--★★ノワール★★:…なにかの、衣装？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_007_0310033")

-- ▼直接出力
ShowImageItem("104000260")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★マルイル★★:降誕祭をイメージしたドレスですね<br>運搬中に破けてしまって…もったいない
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310035")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0047")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クラリス★★:………わあ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310036")

-- ▼直接出力
HideImageItem()
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★マルイル★★:お譲りしましょうか？<br>ワケアリ商品ですのでお安くしますよ！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310037")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
lookat_delay_weight_reset(Actor003 , 0.6)
PlayPartVoiceDirect("クラリス","0040")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★クラリス★★:あ、いえ、似合いませんので～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310038")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0017")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ラグネル★★:
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_007_0310039")

-- ▼直接出力
setup_small_camera_start()
change_face(Actor004,"Normal")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0011")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★マルイル★★:ラグネルさんは消費者の鑑ですね！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310040")

	change_face(Actor003,"Sad")

	--★★クラリス★★:………
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310041")

-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
lookat_delay_weight(Actor006, {0.9, 0.03, 0.6, 0.2} , 1.0)
keep_delay_ik_lookat_object(Actor006,nil,"kara",1.0)
PlayPartVoiceDirect("子供_男1","0002")
-- ▲直接出力

	--★★カイル★★:クラリスお姉ちゃん！！こっちこっち！<br>ボク、これがいいかも！どうかな！？
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0310043")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0028")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:りゅ、竜が巻きついた剣ですか？
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310044")

-- ▼直接出力
set_enable_auto_lookat(Actor006, true)
lookat_delay_weight_reset(Actor006 , 0.6)
PlayActionDirect(Actor006,"to Wlk")
turn_lookat( Actor006,Actor003, 0.3)
wait_time(0.3)
PlayActionDirect(Actor006,"to Std_Loop")
play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★カイル★★:違うよ！これこれ！！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0310045")

-- ▼直接出力
ShowImageItem("104000240")
-- ▲直接出力

	--★★ノワール★★:…──白い、花束？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_007_0310047")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0045")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★マルイル★★:
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310048")


	--★★マルイル★★:『天使の贈り物』と呼ばれ<br>幸運をもたらすと言われています
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310049")

-- ▼直接出力
HideImageItem()
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★カイル★★:幸運…
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0310050")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0007")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★マルイル★★:かなりデリケートな品種でして<br>その束ともなると、とってもレアです！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310051")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0007")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★カイル★★:これがいい！ね！いいよね！？<br>クラリスお姉ちゃん！！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0310052")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★クラリス★★:え、ええ、カイルくんがイイなら～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310053")

	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0012")
-- ▲直接出力

	--★★カイル★★:やった！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0310054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0026")
-- ▲直接出力

	--★★マルイル★★:お買い上げありがとうございます！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310055")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0048")
-- ▲直接出力

	--★★クラリス★★:………わたしが出る幕はありませんでしたね～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ノワール★★:そうかな
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_007_0310057")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0038")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:そうですよ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310059")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
Appear(Actor007)
Appear(Actor008)
Appear(Actor009)
PlayPartVoiceDirect("山賊","0032")
-- ▲直接出力

	--★★ログレス兵？A★★:こんなところにいやがったか<br>手間かけさせやがって
	Talk(Actor007,"CHRNAME_NAMELES","speech","N","EA_007_0310061")

-- ▼直接出力
setup_small_camera_start(CameraEX)
slidemove2(CameraEX,{-16.934,2.052,6.392}, 4,0)
PlayActionDirect(Actor005,"to Wlk")
turn_lookat( Actor005,Actor007, 0.5)
turn_lookat( Actor006,Actor007, 1.5)
turn_lookat( Actor001,Actor007, 0)
turn_lookat( Actor002,Actor008, 0)
turn_lookat( Actor003,Actor008, 0)
turn_lookat( Actor004,Actor008, 0)
--ログレス兵？A,NPCNAME_0390 @名前変更
PlayActionDirect(Actor007,"to Wlk")
slidemove(Actor007,{-13.1,0.128, 10.02}, 1.7)
wait_time(0.2)
PlayActionDirect(Actor008,"to Wlk")
slidemove(Actor008,{-13.07,0.128, 9.19}, 1.7)
wait_time(0.2)
PlayActionDirect(Actor009,"to Wlk")
slidemove(Actor009,{-12.55,0.128, 10.79}, 1.7)
wait_time(0.3)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(1.0)
turn_lookat( Actor007,Actor003, 0.3)
PlayActionDirect(Actor007,"to  Std_Talk")
wait_time(0.2)
turn_lookat( Actor008,Actor002, 0.3)
PlayActionDirect(Actor008,"to Std_Loop")
wait_time(0.2)
turn_lookat( Actor009,Actor002, 0.3)
PlayActionDirect(Actor009,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("山賊","0002")
-- ▲直接出力

	--★★ログレス兵？A★★:大商人のひとり息子<br>カイルで間違いないな？
	Talk(Actor007,"NPCNAME_0390","speech","N","EA_007_0310064")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0015")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ラグネル★★:誰…？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_007_0310065")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("兵士1","0002")
-- ▲直接出力

	--★★ログレス兵？B★★:用があるのはその子どもだけだ<br>引き渡してもらおうか
	Talk(Actor008,"NPCNAME_0391","speech","N","EA_007_0310066")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0045")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:………ログレス兵が<br>迷子案内をやってんのか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_007_0310067")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("山賊","0010")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ログレス兵？A★★:迷子…？ああ、そうだな<br>その迷子を連れ戻しに来たんだ
	Talk(Actor007,"NPCNAME_0390","speech","N","EA_007_0310068")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0040")
-- ▲直接出力

	--★★クラリス★★:ありえませんね～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310069")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
turn_lookat( Actor005,Actor003, 0.5)
wait_time(0.5)
PlayActionDirect(Actor005,"to Std_Loop")
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ノワール★★:クラリス？
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_007_0310070")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力

	--★★クラリス★★:学園を出入りする兵士さんは限られています<br>わたし、その人たちのお顔は大体覚えています
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310071")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("兵士1","0028")
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★ログレス兵？B★★:なに…！？
	Talk(Actor008,"NPCNAME_0391","speech","N","EA_007_0310072")

-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
turn_lookat( Actor005,Actor007, 0.5)
wait_time(0.5)
PlayActionDirect(Actor005,"to Std_Loop")
PlayPartVoiceDirect("クラリス","0015")
-- ▲直接出力

	--★★クラリス★★:あなたたち、どちらさまですか？
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310073")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("山賊","0033")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ログレス兵？A★★:…言うと思うか？
	Talk(Actor007,"NPCNAME_0390","speech","N","EA_007_0310074")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0013")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:言わせてやるよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_007_0310075")

	PlayAction(Actor003,"to  Std_Talk")

	--★★クラリス★★:カイルくんを<br>どうするつもりですか
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310076")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("兵士1","0010")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ログレス兵？B★★:さあね
	Talk(Actor008,"NPCNAME_0391","speech","N","EA_007_0310077")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("山賊","0010")
-- ▲直接出力

	--★★ログレス兵？A★★:でけえ声で話しやがって<br>聞いてたぜ？
	Talk(Actor007,"NPCNAME_0390","speech","N","EA_007_0310078")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("山賊","0013")
-- ▲直接出力

	--★★ログレス兵？A★★:この白い花束が幸運を運ぶって？
	Talk(Actor007,"NPCNAME_0390","speech","N","EA_007_0310080")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0015")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★マルイル★★:あ、あの人、商品を勝手に…！<br>許せません！！泥棒です！！
	Talk(Actor001,"CHRNAME_MARIL","speech","L","EA_007_0310081")

-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0015")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★カイル★★:お、おまえ！！返せよ！！
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0310082")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor006,"to Run")
slidemove(Actor006,{-13.949,0.128, 10.153}, 0.8)
wait_time(0.4)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Surp")
PlayActionDirect(Actor002,"to  Std_Surp")
PlayActionDirect(Actor004,"to  Std_Surp")
change_face(Actor002,"Surprise")
change_face(Actor004,"Surprise")
PlayActionDirect(Actor006,"to  Std_Joy")
PlayAction(Actor001,"to  Std_Surp")
PlayAction(Actor005,"to  Std_Surp")
change_face(Actor001,"Surprise")
change_face(Actor005,"Surprise")
wait_time(0.2)
PlayActionDirect(Actor006,"to  Std_Joy")
PlayPartVoiceDirect("クラリス","0028")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0310083")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101050210", "content_still_10105021_image", "101050210_StillImage")
load_image_preload("104000220", "content_still_10400022_image", "104000220_StillImage")
load_image_preload("104000230", "content_still_10400023_image", "104000230_StillImage")
load_image_preload("104000240", "content_still_10400024_image", "104000240_StillImage")
load_image_preload("104000260", "content_still_10400026_image", "104000260_StillImage")
load_image_preload("104000270", "content_still_10400027_image", "104000270_StillImage")
load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
preload_sound("BGM_ADV_Reconnaissance")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
