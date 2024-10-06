-- このluaスクリプトは、MA_01A900_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
load_image("10103037", "content_still_10103037_image", "101030370_StillImage")
set_common_look_at(Actor001,Actor002,1.0)
set_common_look_at(Actor002,Actor001,1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115162)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:おやすみ、しなくていいの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:眠れなくて。最近
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わたしも
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010004")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ギネヴィア★★:最近、いそがしいよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A900_010007","MA_01A900_010008","MA_01A900_010009")
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
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ちょっと忙しいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_010011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:次の戦いに向けて武器の手入れしようって<br>ガウェインと話ししてて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_010012")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:そっか…<br>そうだよねぇ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:とくに予定はないけど<br>どうして？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_010015")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ほんとう？<br>ほんとうにほんとう？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010016")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ほんとうにほんとうだけど？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_010017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:忙しくても付き合うよ<br>…なにかあるんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_010019")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…わかる？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010020")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:隠し事できないね、ノワールには
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010021")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ちょっぴりだけ…アーサーに時間、もらったの<br>ちゃんと考えて、決める時間…それまでに、ね？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010023")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:あのね？<br>…その、欲しいものが、あって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺に買ってくれって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_010025")

	PlayAction(Actor002,"to  Std_No")

	--★★ギネヴィア★★:ううん…買うものじゃなくて<br>正確に言うと、もの…でもないのかも
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010026")


	--★★ギネヴィア★★:まあ言っちゃえば質素な…<br>慎ましい、当たり障りのない、ことなんだけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010027")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:要領を得ないな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_010028")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:おねだりさせてほしいの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:誘拐してください
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010031")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_010032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…あなたと最初に<br>おでかけしたとこまで
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_010033")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10103037", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
voiceSignalS = voice_play("VO_MA_01A900_010034")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)
fadeout(0,0,0,1.0,2.0)
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10103037", "content_still_10103037_image", "101030370_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115162)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
