-- このluaスクリプトは、CO_101014_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110231_11","110231_11_h")
Include("content_adv_advsmall_110231_11","Template110231_11_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110231_11_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110231_11,CameraPos110231_11_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110231_11_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110231_11,CameraPos110231_11_003)
	Camera003 = SetTemplate("Actor003",20,CharaPos110231_11_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110231_11,CameraPos110231_11_002)
	Camera004 = SetTemplate("Actor005",80,CharaPos110231_11_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110231_11,CameraPos110231_11_007)
	InitializeTemplateRandomCamera110231_11()
	InitializeTemplate110231_11()
-- ▼直接出力
load_image("103050130", "content_still_10305013_image", "103050130_StillImage")
-- ▲直接出力
-- ▼直接出力
bow_01 = set_object("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,0,-5}
on_parent(bow_01,Actor002, "Loc_weapon_constrint_L",weapon_offset)

-- ▲直接出力
-- ▼直接出力
bow_01 = set_object("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,-61,-14.7}
on_parent(bow_01,Actor003, "Loc_weapon_constrint_L",weapon_offset)

-- ▲直接出力
-- ▼直接出力
bow_01 = set_object("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,0,-5}
on_parent(bow_01,Actor005, "Loc_weapon_constrint_L",weapon_offset)

-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor002,8,False)
SkipDefaultMotion(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110231)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101009","002","101009002")
	Actor005 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to  Std_Appl")
	PlayAction(Actor003,"to  Std_Appl")
-- ▼直接出力
PlayPartVoiceDirect("男子1", "0045")
set_animationcontroller(Actor002, "Chr_004_01_StdController", "to Std_Loop")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:す、すごい！<ruby=かいちゅう>皆中</ruby>だ！<br>さすがだなあ、トリスタンくん
	Talk(Actor003,"NPCNAME_0151","speech","L","CO_101014_02020002")

-- ▼直接出力
PlayActionDirect(Actor005,"to  Std_Yes")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
set_common_look_at(Actor002,Actor003)
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:この程度、できて当たり前でしょ<br>驚かれるようなことじゃない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02020004")

	open_select_window_tag(Actor001,"Normal","CO_101014_02020006","CO_101014_02020007","CO_101014_02020008")
	if is_select(1) then
-- ▼直接出力
lookat_delay_weight_reset(Actor002,1.0)
-- ▲直接出力
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:さすがだな。的中率もさることながら<br>射る動作に無駄がいっさいない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02020010")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺にはとても真似できないな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0004")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:へえ、よく見てるじゃない<br>褒めてくれてありがとう、と言っておくよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02020012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:むむ…、剣術なら俺のほうが上だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02020014")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0002")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:それってさ、弓術はボクに<br>負けを認めてるわけだけど…理解してる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02020015")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:う、うぐ…<br>（口ではトリスタンに勝てないな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101014_02020016")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0047")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:本当にすごいなあ<br>今度、俺にも弓術を教えてくれないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02020018")

-- ▼直接出力
PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:考えておくよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02020019")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:暇で暇でしょうがなくて<br>すこぶる機嫌がいいときに教えてあげる
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02020020")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（断られたってことかな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101014_02020021")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Angry")
SkipDefaultMotion(Actor003)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor002,1.0)
wait_time(0.4)
setup_small_camera_start()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,175,0.4)
wait_time(0.6)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor003)
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "激怒")
change_face(Actor001,"Normal")
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:姿勢からなってないんだよ、キミたちは<br>力み過ぎ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02020023")

	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:もっと力抜いて整えないと<br>飛ぶものも飛ばないよ。いいかい…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02020024")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:ああ、なるほど、こうやるのか！<br>でも、これをスムーズにやるのは難しいなあ…
	Talk(Actor003,"NPCNAME_0151","speech","L","CO_101014_02020026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力

	--★★トリスタン★★:練習すれば誰にでもできるようになるよ<br>変に「難しい」と意識しないようにして
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02020027")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（意外だな。あんなに優しい口調で<br>誰かに接することもあるんだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101014_02020028")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:ありがとう、トリスタンくん
	Talk(Actor003,"NPCNAME_0151","speech","L","CO_101014_02020029")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
wait_time(0.2)
show_image("103050130", 0.0, 0.0, 0.2 ,true,false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
wait_time(2.5)
hide_image(0.2)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:そういうの、いいから<br>練習に集中しなよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02020031")

	change_face(Actor004,"Sad")

	--★★ノワール2★★:（…あんまり優しくはないか？）
	Talk(Actor004,"CHRNAME_NOIR","mind","L","CO_101014_02020033")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ2_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103050130", "content_still_10305013_image", "103050130_StillImage")
set_object_preload("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,0,-5}
set_object_preload("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,-61,-14.7}
set_object_preload("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,0,-5}
	InitializeLoad_Preload()
	load_area_scene_preload(110231)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110231_11)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
