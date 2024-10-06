-- このluaスクリプトは、CO_101030_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114031_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_005)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor004, 0.42, -0.232, 2.66, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401020","001","401020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("エレイン", "悩む")
-- ▲直接出力

	--★★エレイン★★:私の家の者が来てくれるはずなのですが…少し遅れているようですね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03030002")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
Appear(Actor004)
wait_time(WAIT_TIME_SHORT)
setup_small_camera_end(Camera002)
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("市民中年_女1","0012")
-- ▲直接出力

	--★★市民（中年女）★★:あら、エレインちゃん帰って来てたのね
	Talk(Actor004,"NPCNAME_0256","speech","L","CO_101030_03030004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:…あっはい、用事が、ありまして…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("市民中年_女1","0002")
-- ▲直接出力

	--★★市民（中年女）★★:聞いてるわよ～
	Talk(Actor004,"NPCNAME_0256","speech","L","CO_101030_03030006")

	PlayAction(Actor004,"to  Std_Talk")

	--★★市民（中年女）★★:キャメロット騎士学術院に入学して早々ナントカっていう儀式を成功させて
	Talk(Actor004,"NPCNAME_0256","speech","L","CO_101030_03030007")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:（ナントカ？ゲシュタルトシフトのことかな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101030_03030008")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("市民中年_女1","0010")
-- ▲直接出力

	--★★市民（中年女）★★:留学生として海の向こうの大きな国にも行ったんでしょう？
	Talk(Actor004,"NPCNAME_0256","speech","L","CO_101030_03030009")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("市民中年_女1","0047")
-- ▲直接出力

	--★★市民（中年女）★★:この村の誇りだわさすが『アストラットの美姫』よねえ
	Talk(Actor004,"NPCNAME_0256","speech","L","CO_101030_03030010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:はい…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:（エレイン…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101030_03030014")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
wait_time(WAIT_TIME_SHORT)
Appear(Actor005)
setup_small_camera_end(Camera001)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定")
-- ▲直接出力

	--★★市民（中年男）★★:エレイン様！すみません、遅くなってしまいました
	Talk(Actor005,"NPCNAME_0272","speech","L","CO_101030_03030016")

-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:あっ！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03030017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0006")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:おばさん、すみませんこれで失礼します
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03030019")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_女1", "肯定")
-- ▲直接出力

	--★★市民（中年女）★★:あら、そう？<br>またいつでも顔を見せに戻って来てね
	Talk(Actor004,"NPCNAME_0256","speech","L","CO_101030_03030020")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

se_play("SE_ADV_CO_101030_0303_Foot_1_Person")
Hide(Actor004)
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.9, 0.6} , 1)
keep_ik_lookat(Actor002,Actor003,"J_Head")
wait_time(1.0)

fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★市民（中年男）★★:この子がトビーくんですね<br>話は聞いています
	Talk(Actor005,"NPCNAME_0272","speech","L","CO_101030_03030022")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:トビーくん、この人は私の家で働いていてねあなたの面倒を見てくれることになっているの
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03030023")


	--★★エレイン★★:私は学校があるからずっと一緒にはいてあげられないけど
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03030024")

-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:時間があるときは来るようにするからこの人の言うことを聞いて、ゆっくり休んでね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03030025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:…うん、わかった
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_03030026")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
se_play("SE_ADV_CO_101030_0303_Foot_2_Peaple")
wait_time(1.0)

Hide(Actor003)
Hide(Actor005)
lookat_delay_weight(Actor002, 0.4, 0.08, 0.8, 0.6 , 1)
keep_ik_lookat(Actor002,Actor001,"J_Head")
set_enable_auto_lookat(Actor001,false)
set_common_look_at(Actor001,Actor002)
turn_lookat(Actor001,Actor002,0)
setup_small_camera_start()
wait_time(0.8)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:今日のところは帰りましょう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03030028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エレイン★★:私は時間があるときに様子を見に来ようと思います
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03030029")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_エレイン_ランクアップ3_4")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401020","001","401020001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
