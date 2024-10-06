-- このluaスクリプトは、MA_01A109_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",103.7,CharaPos110191_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_003)
	Camera002 = SetTemplate("Actor002",-85,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
gogai = setup_prop_object(10106003)
-- ▲直接出力
-- ▼直接出力
off_active(gogai)
-- ▲直接出力
-- ▼直接出力
gogai_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.0)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002,1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネマウア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:ご挨拶が遅れました<br>ノワール様
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180002")

	PlayAction(Actor002,"to Bow")

	--★★ギネマウア★★:引き続きよろしくお願いいたします
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_180004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:殿下はノワール様とのGSを果たしました
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180005")


	--★★ギネマウア★★:それにより私というキラーズは<br>殿下のバイブスに繋がっているのと同時に──
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力

	--★★ギネマウア★★:継承者様のバイブスとも結びついたようです
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180009")

	change_face(Actor002,"Smile")

	--★★ギネマウア★★:姉妹ともども戦列に加わります<br>その際は、何卒
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:心強いです<br>こちらこそよろしくお願いしま──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_180013")

-- ▼直接出力
 --PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★ギネマウア★★:それはそうとノワール様<br>御覧になりましたか？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","N","MA_01A109_180015")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、それはそうと…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_180016")

-- ▼直接出力
PlayActionDirect(Actor002,"to LookFor")
se_play("SE_ADV_MA_01B112_49_Cloth")
-- ▲直接出力
	PlayAction(Actor002,"to Show")
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力

	--★★ギネマウア★★:こちら、校内に張り出してある号外です<br>私が作りました。どうぞ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180017")

-- ▼直接出力
se_play("SE_ADV_MA_01105_28_Paper")
PlayActionDirect(Actor001,"to ReadLetter")
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to ReadLetter")
on_parent(gogai,Actor001, "Loc_weapon_constrint_L", gogai_offset)
on_active(gogai)
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:ご、ご丁寧にどうも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_180018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★テロップ★★:「拝啓親愛なる学園生徒諸君」
	Talk(Actor003,"telop","narration","N","MA_01A109_180019")


	--★★テロップ★★:「すでにご存じのことと思いますが」
	Talk(Actor003,"telop","narration","N","MA_01A109_180020")


	--★★テロップ★★:「カレドニア王ライエンスとの戦いにより<br>継承者は覚醒を果たしました」
	Talk(Actor003,"telop","narration","N","MA_01A109_180021")

-- ▼直接出力
setup_small_camera_end(Camera001)
-- ▲直接出力

	--★★テロップ★★:「我ら人類の救世主、ブリテンが産んだ秘宝<br>ログレスの希望、学園が見出した答え」
	Talk(Actor003,"telop","narration","N","MA_01A109_180022")


	--★★テロップ★★:「それこそが円卓の騎士<br>ブルーノ・ル・ノワールです」
	Talk(Actor003,"telop","narration","N","MA_01A109_180023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:も、持ち上げ過ぎでは…！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01A109_180025")

	close_cutin()
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:これからは継承者様を学園全体で守護しつつ<br>逃げも隠れもせず侵略者どもを迎え撃つ──
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180026")


	--★★ギネマウア★★:そういった学園からの表明でもあります
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180027")


	--★★テロップ★★:「そして継承者の劔となったのはこのわたし<br>ギネヴィア・アロンダイト」
	Talk(Actor003,"telop","narration","N","MA_01A109_180028")


	--★★テロップ★★:「ログレス国王妃ギネヴィアの名において<br>X日、講堂へ集まることを命ず」
	Talk(Actor003,"telop","narration","N","MA_01A109_180029")

-- ▼直接出力
setup_small_camera_end(Camera001)
PlayActionDirect(Actor001,"to  Std_Surp")
off_parent(gogai)
off_active(gogai)
SkipOffsetCamera(Camera001)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A109_180031","MA_01A109_180032")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なにか良からぬことを企んでいるな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_180034")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:ノワール様、殿下のこれまでを見たうえで<br>そう予想されるのであれば幻滅です
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ギネマウア★★:殿下の前で<br>そのようなことを口走りませんよう
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180036")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:なにかを派手にやろうとしているな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_180038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:はい<br>殿下なりの精一杯です
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180039")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:派手になるかはわかりませんが<br>彼女なりのけじめとなるはずです
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180040")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:どうか、見届けてあげてください
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A109_180042")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10106003)
gogai_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
