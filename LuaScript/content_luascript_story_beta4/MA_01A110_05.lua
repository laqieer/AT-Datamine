-- このluaスクリプトは、MA_01A110_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:もとには戻りませんね…なにも
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050002")

	open_select_window_tag(Actor001,"Normal","MA_01A110_050004","MA_01A110_050005","MA_01A110_050006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight(Actor001, {0.7, 0.08, 0.6, 0.5} , 0.2)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.2)
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:町並みは、もとに戻り始めているよ<br>再興も──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_050008")

	change_face(Actor002,"Sad")

	--★★エレイン★★:多くが<ruby=うしな>喪</ruby>われる惨状を<br>目の前で見ました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050009")

-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:変わらない景色が<br>逆に残酷です
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001, {0.7, 0.08, 0.6, 0.5} , 0.2)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.2)
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:子供たちが帰る家は残ってる<br>かろうじてだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_050012")

	change_face(Actor002,"Sad")

	--★★エレイン★★:…帰して、あげたかったんです<br>連れて来られて、良かった
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:嬉しい、ですよね、きっと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050014")

	change_face(Actor002,"Normal")

	--★★エレイン★★:ほかにだれも<br>のこっていなくても、きっと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050015")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ルーシャス、許せないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_050017")

	change_face(Actor002,"Sad")

	--★★エレイン★★:あの方が口にしたとおり<br>復讐…なのだとしても
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050018")

-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:…あの方は<br>なにを守ろうとしているんでしょうか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050019")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk_2P(Actor004,Camera004,EntryData114011_01_05,CameraAssetBundleName114011_01,CameraPos114011_01_105,Actor003,CharaPos114011_01_004,CharaPos114011_01_104)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("子供_女1", "挨拶")
-- ▲直接出力

	--★★子供（女）★★:おねえちゃん、おねえちゃん
	Talk(Actor004,"NPCNAME_0140","speech","N","MA_01A110_050021")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
lookat_delay_weight(Actor002, 0.7, 0.08, 0.6, 0.2,0.6)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.7)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.7)
turn_chara(Actor003, -142, 0)
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:おかえりなさい<br>どうでしたか、お家は
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050022")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("子供_女1", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★子供（女）★★:それがね、それがね<br>家はね、わかったんだ
	Talk(Actor004,"NPCNAME_0140","speech","N","MA_01A110_050023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:無事帰れたんですね<br>おねえさんも安心しましたよ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050024")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("子供_女1", "照れ")
-- ▲直接出力

	--★★子供（女）★★:おまつりのね、かざりも無事だったんだ<br>家族みんなで作ったから、のこっててよかった！
	Talk(Actor004,"NPCNAME_0140","speech","N","MA_01A110_050025")

	change_face(Actor001,"Normal")

	--★★ノワール★★:おまつり？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_050026")

-- ▼直接出力
lookat_delay_weight(Actor002, 0.7, 0.08, 0.8, 0.2,0.6)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.7)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:カレドニア育ちの先輩は<br>ご存じないですよね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050027")

-- ▼直接出力
lookat_delay_weight(Actor001, {0.7, 0.08, 0.6, 0.5} , 0.2)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.7)
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なぜ俺がカレドニア育ちだと…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_050028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:…えへへへ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050029")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:笑ってごまかされた…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_050030")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:毎年このくらいの時期になると<br>ロンディニウムをあげての祭が開催されるんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050031")


	--★★エレイン★★:海の向こうのローマ大帝国からも<br>たくさんの人が来て…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:いろんな出店、さまざまな催し物が出て<br>それはそれは盛り上がるんです、楽しいんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050033")

-- ▼直接出力
 --PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★子供（男）★★:おまつり、したかった
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor002, 0.7, 0.08, 0.6, 0.2,0.6)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.7)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.7)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:…そうですね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050035")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("子供_男2", "落胆")
-- ▲直接出力

	--★★子供（男）★★:でもね、わかんないんだ<br>かえれば…わかると思ったんだけど
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050036")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:わからない？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050037")

-- ▼直接出力
 --PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）★★:家には誰かいたみたいなんだけど<br>ぼく以外にも誰かいたみたいなんだけど
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050038")

-- ▼直接出力
setup_small_camera_end()
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad02")
-- ▲直接出力
-- ▼直接出力
change_face(Actor004,"Sad")
-- ▲直接出力

	--★★子供（男）★★:おもいだせないんだ
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050039")


	--★★子供（男）★★:おとうさんや、おかあさんの、かおが
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050040")

-- ▼直接出力
 --PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力

	--★★子供（男）★★:おとなりさんのことも、おもいだせないの<br>ともだちも誰がいたかわからないの
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:そう、そう、ですか…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050043")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）★★:誰かがいた気がするんだよ<br>一緒にいた気がするんだよ
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050045")

	change_face(Actor003,"Sad")

	--★★子供（男）★★:しんじゃったのかな<br>だけどよくわからないんだ
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050046")


	--★★子供（男）★★:よくわからないけど
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050047")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:寂しいですよね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050048")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
 --PlayPartVoice("子供_男2", "落胆")
-- ▲直接出力

	--★★子供（男）★★:さびしいよ
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:寂しいですよね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_050050")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad02")
-- ▲直接出力

	--★★子供（男）★★:かえってきたのに、かえってこないよ
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050051")

-- ▼直接出力
 --PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力

	--★★子供（男）★★:ぼく、さびしがっていいんだよね？
	Talk(Actor003,"NPCNAME_0141","speech","N","MA_01A110_050052")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
