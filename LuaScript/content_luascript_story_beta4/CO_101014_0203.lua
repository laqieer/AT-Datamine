-- このluaスクリプトは、CO_101014_0203.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110181_01","110181_01_h")
Include("content_adv_advsmall_110181_01","Template110181_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110181_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110181_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110181_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110181_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_007)
	InitializeTemplateRandomCamera110181_01()
	InitializeTemplate110181_01()
-- ▼直接出力
harp=setup_prop_object(10101017)
harp_offset={0,0,0,0,0,0}
on_parent(harp,Actor002,"Loc_weapon_constrint_R", harp_offset)
on_active(harp)
chair_01 = get_object("geo_chair_04")
set_pos(chair_01, {0.14,0,1.2})
set_rot(chair_01,{0,180,0})
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to hurpplay_loop")
se_play("SE_ADV_CO_101014_1002_Harp_Arp")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110181)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Appl")
PlayActionDirect(Actor003,"to  Std_Appl")
PlayActionDirect(Actor004,"to  Std_Appl")
PlayActionDirect(Actor002,"to hurp_loop")
se_play("SE_ADV_Loop_Stop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
wait_time(WAIT_TIME_NORMAL)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:いやー、やっぱトリスタンの竪琴はいいな！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101014_02030002")


	--★★ガウェイン★★:俺には音楽の理論のこととか<br>形式のこととかはよくわかんねーけどさ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101014_02030003")

-- ▼直接出力
setup_small_camera_end()
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101014_02030005","CO_101014_02030006","CO_101014_02030007")
	if is_select(1) then
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
set_animationcontroller(Actor002,"Chr_004_01_StdController","to Std_Loop")
off_parent(harp)
set_pos(harp, {0.12,0.815,0.7})
set_rot(harp,{0,-15,-30})
set_pos(chair_01, {0.14,0,0.6})
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02030009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンの歌は<br>聞いていると疲れが飛んでいく気がするけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02030010")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:トリスタンの竪琴は<br>なんかこう、心が安らかになっていくというか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02030012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0041")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:へえ？それが本当なら<br>キミの妹の歌、ちょっと気になるね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02030013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
set_animationcontroller(Actor002,"Chr_004_01_StdController","to Std_Loop")
off_parent(harp)
set_pos(harp, {0.12,0.815,0.7})
set_rot(harp,{0,-15,-30})
set_pos(chair_01, {0.14,0,0.6})
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺もなにか楽器を覚えてみようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02030015")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:なあ、トリスタン<br>俺にできそうな楽器ってないかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02030016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0041")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:「できそうな楽器があったらやる」<br>なんて気持ちじゃ長続きしないと思うよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02030017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そ、そうか…悪い
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02030018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_animationcontroller(Actor002,"Chr_004_01_StdController","to Std_Loop")
off_parent(harp)
set_pos(harp, {0.12,0.815,0.7})
set_rot(harp,{0,-15,-30})
set_pos(chair_01, {0.14,0,0.6})
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ホント、上手いもんだなあ<br>誰かに習ったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02030020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:…どうだったかな<br>もう忘れちゃったよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02030022")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:そ、そうか…なんか、ごめん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02030023")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力

	--★★ガウェイン★★:なあ、トリスタン！<br>もう１曲聞かせてくれよ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101014_02030025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:嫌だよ<br>演奏会じゃないんだから
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02030026")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:そこをなんとか！<br>頼む、友達だろ！？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101014_02030027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:はあ…<br>しかたないね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02030028")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力

	--★★ガウェイン★★:よっしゃ！サンキュー、トリスタン！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101014_02030029")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:もうただのファンだな、ガウェイン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_02030031")

-- ▼直接出力
PlayPartVoice("ラグネル", "喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:あはは
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101014_02030033")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力

	--★★ラグネル★★:でも、あたしもトリスタンの竪琴は大好きだし<br>あたしたち以外にもファンは大勢いるよ
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101014_02030034")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0007")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ラグネル★★:みんな<br>心の安らぎが欲しいんじゃないかな
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101014_02030035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:心の安らぎ、ね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02030037")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:…自分の心のキズも治せたなら<br>どんなに良いだろうね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_02030038")

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to  Std_Worry")
wait_time(WAIT_TIME_NORMAL)
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("トリスタン_コミュランク", "トリスタン_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101017)
harp_offset={0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(110181)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110181_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
