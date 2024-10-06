-- このluaスクリプトは、EA_001_051.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",257,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera002 = SetTemplate("Actor002",308,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera004 = SetTemplate("Actor004",70,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera005 = SetTemplate("Actor005",180,CharaPos112021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_007)
	Camera006 = SetTemplate("Actor006",130,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera007 = SetTemplate("Actor007",61,CharaPos112021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_007)
	Camera008 = SetTemplate("Actor008",12,CharaPos112021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_008)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
load_image("104000010", "content_still_10400001_image", "104000010_StillImage")
load_image("201010020", "content_still_20101002_image", "201010020_StillImage")
set_pos(Actor001,{-1.698,0,1.209})
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-1.766,0,1.047})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{0.706,0,5.547})
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{-2.32,0.046,1.835})
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007,{-2.837,0,0.851})
set_enable_auto_lookat(Actor007,false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{-1.759,0,-0.087})
set_enable_auto_lookat(Actor008,false)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_EA_001_051_Lively_Crowds_Loop")
-- ▲直接出力
-- ▼直接出力
load_image("103050110", "content_still_10305011_image", "103050110_StillImage")
show_image("103050110",0.0,0.0,0.0,true,false)
-- ▲直接出力
-- ▼直接出力
set_position_image(0,-50)
set_scale_image(1.2,1.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401020","001","401020001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
move_to_image(0,50,4.0,"EaseIn")
wait_time(5.5)
fadeout(0.0, 0.0, 0.0, 1.0, 1.0)
wait_time(1.0)
hide_image(0)
wait_time(1.0)
setup_small_camera_start(RndCamera008)
fadein(1.0)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0038")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:君らの『ガワ』を『イイ』モノに！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_051002")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor006,"J_Head",0.2)
-- ▲直接出力
	PlayAction(Actor006,"to Greet_one")
-- ▼直接出力
PlayPartVoice("市民_男1","肯定3")
-- ▲直接出力

	--★★客★★:俺のズボンを縫ってくれ！！<br>破けちまったがお気に入りなんだ！！
	Talk(Actor006,"NPCNAME_0230","speech","N","EA_001_051003")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("市民中年_女1","0002")
-- ▲直接出力

	--★★客2★★:ジイサンのくれたブラウスも直せるかい！？<br>また着られると思うと嬉しくて嬉しくて…！
	Talk(Actor007,"NPCNAME_0231","speech","N","EA_001_051004")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0011")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:は～い！よろこんで！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_051005")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:五月祭で衣服の直し屋を出すって聞いたけど…<br>とんでもない盛況ぶりだ………！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_051007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0008")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:カワイイと感じるものは<br>人によって違うって気づいたんでしょ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_001_051009")

-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0010")
-- ▲直接出力

	--★★イゾルデ★★:あの子、最初から腕はプロ顔負けだもの
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_001_051010")


	--★★イゾルデ★★:豪速、剛腕、かつ繊細な針さばきで<br>愛着ある服が好みに仕上がるとなればね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_001_051011")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:イゾルデ<br>キミはどうしてあんな周りくどいやりかたで？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_051012")

	change_face(Actor003,"Normal")

	--★★イゾルデ★★:ダメ元のショック療法よ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_001_051014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ","肯定")
-- ▲直接出力

	--★★イゾルデ★★:ケイ先生は本気で潰そうとしていたし<br>解決の糸口を見出せなければ彼女もそれまで
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_001_051015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0,346,0,0.3)
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ","肯定2")
-- ▲直接出力

	--★★イゾルデ★★:直接的な助言をしなかったのは<br>まあ…軽い腹いせね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_001_051016")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,95,0,0.3)
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Greet_one")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:あ、イゾルデちゃーん！待って待って！<br>あげたいものあるのっ！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_051018")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Run")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor001,{1.525,0,1.366},1.3)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0,265,0,0.35)
-- ▲直接出力
-- ▼直接出力
wait_time(0.35)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.85)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to LookFor")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★イゾルデ★★:礼には及ばないわ。己の仕事を果たしなさい<br>私になにをくれ、る、と──…？
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_001_051020")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Show")
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力
-- ▼直接出力
ShowImageItem("104000010")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:………紫色の、動物？の？ぬいぐるみ…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_051021")

-- ▼直接出力
PlayPartVoice("ラグネル","喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:犬にしようと思ったんだけど布足りなくて<br>カバみたいなよくわかんない獣になった！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_051022")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:これは…カワイイ、のか…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_051024")

-- ▼直接出力
HideImageItem()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
	change_face(Actor003,"Surprise")

	--★★イゾルデ★★:………もらっておくわね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_001_051026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラグネル★★:え！？声小さくてよく聞こえない！<br>いらないなら売っちゃうけど！？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_051027")

-- ▼直接出力
play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ","照れ")
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★イゾルデ★★:いいえ！！とりあえずもらっておくからっ！！<br>ああしょうがない！一旦預からせてもらうわ！！ 
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","EA_001_051029")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.35)
lookat_delay_weight_reset(Actor003,1.0)
wait_time(0.15)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0,0,0,0.2)
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor003,{2.229,0,5.5},1.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,0,0,0.4)
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,0,0.3)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.1)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:今日もカワイイなあ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_051031")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor004,-0.012,0,1.642,1.6)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0,108,0,0.2)
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Laugh")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ","肯定2")
-- ▲直接出力

	--★★ケイ★★:よくも仕事を増やしてくれたな、ラグネル
	Talk(Actor004,"CHRNAME_KAY","speech","L","EA_001_051033")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn(Actor001,0,283,0,0.3)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-70,0.3)
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Greet_one")
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:いらっしゃいませー！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_051034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ","肯定")
-- ▲直接出力

	--★★ケイ★★:問い合わせが殺到している<br>貴公に服の直しを頼みたいと
	Talk(Actor004,"CHRNAME_KAY","speech","L","EA_001_051035")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ケイ★★:ブリテン中が<br>貴公の<ruby=ぬいぐるみ>『縫う包み』</ruby>を求めてな
	Talk(Actor004,"CHRNAME_KAY","speech","L","EA_001_051036")

-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:………ははっ、すごいな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_051037")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,160,0,0.4)
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラグネル★★:あっ。笑った
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_051038")

	change_face(Actor002,"Laugh")

	--★★ノワール★★:ん？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_051039")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル","笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:んーん。なぁんでもないっ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_051040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,283,0,0.3)
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル","挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:それでケイ先生？<br>廃部は撤回？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_051042")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ","落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ケイ★★:ルールを遵守されては<br>寛大にならざるをえんな
	Talk(Actor004,"CHRNAME_KAY","speech","L","EA_001_051044")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor005,0.706,0,2.252,2.1)
-- ▲直接出力
-- ▼直接出力
wait_time(2.1)
-- ▲直接出力
-- ▼直接出力
turn(Actor005,0,246,0,0.3)
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ","笑い")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ローラ★★:ケイ先生、お待ちしてました<br>こちらを…あの、受け取ってください
	Talk(Actor005,"CHRNAME_LOLA","speech","L","EA_001_051046")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayAction(Actor005,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0,33,0,0.4)
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:…？なんだね、このハンカチは──
	Talk(Actor004,"CHRNAME_KAY","speech","L","EA_001_051047")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ","喜び")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ローラ★★:メガネ拭き、つくりました
	Talk(Actor005,"CHRNAME_LOLA","speech","L","EA_001_051048")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
change_face(Actor004,"Surprise")
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
change_face(Actor004,"Smile")
-- ▲直接出力
-- ▼直接出力
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル","喜び")
-- ▲直接出力

	--★★ラグネル★★:<ruby=メガネ>そこ</ruby>が急所だもんねー？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_051051")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
show_image("201010020", 0.0, 0.0, 0,true,false)
wait_time(TIME_ELAPSED)
se_play("SE_ADV_EA_001_051_Sewing")
fadein(FADE_TIME)
wait_time(FADE_TIME + 2.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラグネル★★:身の丈に合うかどうか<br>じゃないね
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","EA_001_051055")


	--★★ラグネル★★:みんな、なりたい自分があって<br>追いかける『憧れのサイズ』はいつも大きくて
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","EA_001_051056")

-- ▼直接出力
PlayPartVoice("ラグネル","笑い")
-- ▲直接出力

	--★★ラグネル★★:だからあたしもあたしなりに着たい服着て<br>君みたいにカッコよく見栄張り続けて
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","EA_001_051057")


	--★★ラグネル★★:結果なに言われたって<ruby=ドンマイ>大丈夫</ruby>だよね<br>そうやって大口叩いてくほうが──
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","EA_001_051058")

-- ▼直接出力
PlayPartVoice("ラグネル","喜び")
-- ▲直接出力

	--★★ラグネル★★:<ruby=かわい>あたし</ruby>らしくて、いいでしょ？
	Talk(Actor001,"CHRNAME_RAGNAR","simple","N","EA_001_051059")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000010", "content_still_10400001_image", "104000010_StillImage")
load_image_preload("201010020", "content_still_20101002_image", "201010020_StillImage")
load_image_preload("103050110", "content_still_10305011_image", "103050110_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401020","001","401020001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
