-- このluaスクリプトは、MA_01A111_44.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation04","DuelCommonFormation04_h")
Include("content_adv_advsmall_duelcommonformation04","TemplateDuelCommonFormation04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation04_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_011)
	InitializeTemplateRandomCameraDuelCommonFormation04()
	InitializeTemplateDuelCommonFormation04()
-- ▼直接出力
prop = setup_prop_object(10130021)
set_pos(prop,{0, 0, -1.1})
set_rot(prop,{0,-107.2,0})
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor001,prop,"Geo_Pro_1091")
change_face(Actor001,"Pain")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Kneeling")
change_face(Actor002,"Pain")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
load_image("101030400", "content_still_10103040_image", "101030400_StillImage")
load_image("101030410", "content_still_10103041_image", "101030410_StillImage")
load_image("101030420", "content_still_10103042_image", "101030420_StillImage")
load_image("101030430", "content_still_10103043_image", "101030430_StillImage")
load_image("101030510", "content_still_10103051_image", "101030510_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
RndCamera001sub = RndCamera001
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera002
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101200011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1.5)
fadeout(255,255,255,1,0.1)
se_play("SE_ADV_MA_01A111_44_Whoosh")
wait_time(0.2)
show_image("101030510", 0.0, 0.0, 0 ,true,false) 
fadein(0.1)
wait_time(0.6)
fadeout(255,255,255,1,0.1)
se_play("SE_ADV_MA_01A111_44_Whoosh")
wait_time(0.2)
show_image("101030400", 0.0, 0.0, 0 ,true,false) 
fadein(0.1)
wait_time(0.6)
fadeout(255,255,255,1,0.1)
se_play("SE_ADV_MA_01A111_44_Whoosh")
wait_time(0.2)
show_image("101030410", 0.0, 0.0, 0 ,true,false) 
fadein(0.1)
wait_time(0.6)
fadeout(255,255,255,1.0,0.1)
se_play("SE_ADV_MA_01A111_44_Whoosh")
wait_time(0.2)
show_image("101030420", 0.0, 0.0, 0 ,true,false) 
fadein(0.1)
wait_time(0.6)
fadeout(255,255,255,1.0,0.1)
se_play("SE_ADV_MA_01A111_44_Whoosh")
wait_time(0.2)
show_image("101030430", 0.0, 0.0, 0 ,true,false) 
fadein(0.1)
wait_time(0.6)
 --[[
fadeout(255,255,255,1.0,0.1)
wait_time(0.2)
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
fadein(0.1)
wait_time(0.2)
 --]]
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false,ture)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★ルーシャス★★:余は惰眠を貪る民が嫌いだ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","N","MA_01A111_440002")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
hide_image(BLACK_WHITE_TIME)
Appear(Actor003)
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_start(Camera003)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor003)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ルーシャス★★:甘い信頼が睡眠を誘う<br>寝首をかかれぬか疑うこともなく
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440004")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★ルーシャス★★:死の予感を持たず寝る者など<br>使い物にもならんよ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440005")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:…ルーシャス
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_440006")

	change_face(Actor003,"Normal")

	--★★ルーシャス★★:リンゴ狩りをやり、祭りをやり、騒ぎ<br>惚れた腫れたで一喜一憂、師弟で要らぬ悶着
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440007")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ルーシャス★★:クッククククククククククク<br>アッハッハッハッハッハッハッハ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440008")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:なにが、なにが、おかしいのよ…！！
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A111_440009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:いやね、そなたでなければ<br>暴れ馬は…ああはならなかったかもと思ってね？
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440010")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ノワール★★:ガラハッドを穢したのは<br>貴様らだろう…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_440012")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ルーシャス★★:そこに転がる最強騎士もそうだが<br>まあ殺さぬよう加減した結果敗れたわけだ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440014")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★ルーシャス★★:ギネヴィア…そなたは加減する力量すらなく<br>無我夢中で勝利を求め、結果、殺し、勝った
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440015")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…ッ！？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A111_440016")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ルーシャス★★:…本当を言えばギネヴィア<br>そんなそなたが好きでね
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:わたしは、嫌いよ<br>これまでもこれからもずっと…！
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","MA_01A111_440018")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:その深みのない薄氷のような見栄<br>奥に透けて見える独占欲
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440019")


	--★★ルーシャス★★:「ずっと誰かの一番でいたい」<br>「自分だけを見て欲しい」と
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440020")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ルーシャス★★:「飾り立てたわたしを見て！」と<br>パパにねだるおぼこのようで
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440021")

-- ▼直接出力
setup_small_camera_start(RndCamera001sub)
-- ▲直接出力

	--★★ルーシャス★★:その目の覚めるような薄情さは<br>我が母君のように気色悪く思えた
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440023")

	change_face(Actor003,"Smile")

	--★★ルーシャス★★:振り回してやれば万華鏡のように<br>綺麗さと奇妙さがくるくると回る魅力
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440024")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ルーシャス★★:実に美しかった
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440025")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:…そんなことのために、ギネヴィアを…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_440026")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:その脆き殻の奥<br>紅色の性根を見せてくれ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","R","MA_01A111_440027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130021)
load_image_preload("101030400", "content_still_10103040_image", "101030400_StillImage")
load_image_preload("101030410", "content_still_10103041_image", "101030410_StillImage")
load_image_preload("101030420", "content_still_10103042_image", "101030420_StillImage")
load_image_preload("101030430", "content_still_10103043_image", "101030430_StillImage")
load_image_preload("101030510", "content_still_10103051_image", "101030510_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
RndCamera001sub = RndCamera001
RndCamera001 = RndCamera002
	InitializeLoad_Preload()
	load_duel_scene_preload(101200011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
