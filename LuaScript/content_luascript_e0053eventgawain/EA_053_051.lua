-- このluaスクリプトは、EA_053_051.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_04","110111_04_h")
Include("content_adv_advsmall_110111_04","Template110111_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",45,CharaPos110111_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	Camera003 = SetTemplate("Actor003",220,CharaPos110111_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_005)
	Camera004 = SetTemplate("Actor005",0,CharaPos110111_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_003)
	Camera005 = SetTemplate("Actor006",nil,CharaPos110111_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_003)
	Camera006 = SetTemplate("Actor007",nil,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	InitializeTemplateRandomCamera110111_04()
	InitializeTemplate110111_04()
-- ▼直接出力
Hide(Actor002)
set_pos(Actor003,{-1.08, 0, 5.22})
set_pos(Actor007,{-7.43, 0, 11.6})
Hide(Actor003)
Hide(Actor006)
BgProp = setup_prop_object(10102009)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いよいよ五月祭当日か<br>なんだかワクワクしてきたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0510005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("市民_女1","0002")
-- ▲直接出力

	--★★女性★★:ガウェインさん、こっちこっち！
	Talk(Actor005,"NPCNAME_0182","speech","N","EA_053_0510006")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0008")
-- ▲直接出力
	change_face(Actor007,"Laugh")

	--★★ガウェイン2★★:おう！まかせとけ！
	Talk(Actor007,"CHRNAME_GAWAIN","speech","L","EA_053_0510008")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Appear(Actor002)
turn_lookat(Actor001,Actor002,0)
turn_chara(Actor005,248,0)
wait_time(2.0)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ガウェイン★★:よっと…荷物はこれで全部か？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0510011")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("市民_女1","0036")
-- ▲直接出力

	--★★女性★★:ありがとう<br>私ひとりじゃ重くてとても運べなくて
	Talk(Actor005,"NPCNAME_0182","speech","N","EA_053_0510012")

	PlayAction(Actor005,"to  Std_Talk")

	--★★女性★★:ごめんなさいね。円卓の任務を済ませたばかりで<br>疲れているでしょうに
	Talk(Actor005,"NPCNAME_0182","speech","N","EA_053_0510013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:いいっていいって！<br>困ったことがあればいつでも呼んでくれよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0510014")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,0,0.8)
wait_time(0.8)
change_face(Actor002,"Normal")
slidemove(Actor005,{-6, 0, 11}, 4.0)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,10,1.5)
wait_time(1.5)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.5)
Hide(Actor005)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
voice_play("VO_101009_sp_0005_1")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今日も忙しそうだな、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0510016")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101013_sp_0001_1")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ノワール
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0510017")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

Hide(Actor001)
Appear(Actor006)
turn_chara(Actor002,91,0)
setup_small_camera_start()
wait_time(2.0)

fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
setup_small_camera_start(Camera005)
-- ▲直接出力
	open_select_window_tag(Actor006,"Normal","EA_053_0510019","EA_053_0510020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor006,"to  Std_Worry")
	change_face(Actor006,"Laugh")

	--★★ノワール2★★:「ヒーローは何でも屋じゃない」<br>――じゃなかったっけ？
	Talk(Actor006,"CHRNAME_NOIR","speech","L","EA_053_0510023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0034")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:いや、まぁ、それはそうなんだけどさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0510024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:けどそういうことをぐずぐず考えるのも<br>ヒーローらしくねえだろ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0510025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ノワール2★★:ラグネルの様子は見に行ったのか？
	Talk(Actor006,"CHRNAME_NOIR","speech","L","EA_053_0510028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0050")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:いや。忙しくて結局行けてねーんだよな<br>あっちはあっちで色々大変みてーだけど…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0510029")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ま、アイツなら大丈夫だろ<br>アイツの手芸の<ruby=スキル>腕</ruby>は本物だからな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0510030")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:そういや、そろそろお菓子を配る時間だよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0510033")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ノワール2★★:ああ。リオネスが張り切ってたよ
	Talk(Actor006,"CHRNAME_NOIR","speech","L","EA_053_0510034")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Laugh")

	--★★ノワール2★★:ひとりで配るのは大変だろうし<br>俺も手伝おうかなと思ってる
	Talk(Actor006,"CHRNAME_NOIR","speech","L","EA_053_0510035")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:手伝う…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0510036")

	change_face(Actor006,"Normal")

	--★★ノワール2★★:…？なんだよ<br>俺の顔になにかついてる？
	Talk(Actor006,"CHRNAME_NOIR","speech","L","EA_053_0510037")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:いや。なんつーか…再確認<br>お前って、やっぱイイ奴だよなぁって――
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0510038")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
setup_small_camera_start()
Appear(Actor003)
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0031")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:た、た、た、大変だー！！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_053_0510040")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
PlayActionDirect(Actor006,"to Wlk")
turn_lookat(Actor002,Actor003,0.4)
turn_lookat(Actor006,Actor003,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor006,"to Std_Loop")
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003,{-5.59, 0, 2.67},1.5)
wait_time(1.5)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(1.5)
setup_small_camera_start(Camera005)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0021_1")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ノワール2★★:リオネス！？どうしたんだ
	Talk(Actor006,"CHRNAME_NOIR","speech","L","EA_053_0510042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★リオネス★★:それが…コック長が盗賊に襲われて…！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_053_0510043")

	open_cutin(2,1)
	on_cutin(1,Actor006,"Surprise")
	on_cutin(2,Actor002,"Surprise")

	--★★ノワール/ガウェイン★★:！！
	Talk(Actor004,"CHRNAME_NOIR_GAWAIN","speech","N","EA_053_0510044")

	close_cutin()
-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0029")
-- ▲直接出力

	--★★ガウェイン★★:な、なんだって！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0510045")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★ノワール2★★:コック長は無事なのか！？
	Talk(Actor006,"CHRNAME_NOIR","speech","L","EA_053_0510046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リオネス_003","0019")
-- ▲直接出力

	--★★リオネス★★:命に別状はないって…でも――！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","EA_053_0510047")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102009)
preload_sound("BGM_ADV_Antagonism")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
