-- このluaスクリプトは、PT6_01_04_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:ここ、いいかしら？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT6_01_04_0010005")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:いいかしらもなにも<br>もう座ってるじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_04_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:細かいこと気にしないでよ<br>それで？今日はひとりぼっちでランチ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT6_01_04_0010007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:ご飯は誰かと一緒に食べたほうが<br>楽しいわよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT6_01_04_0010008")


	--★★ノワール★★:キミだってひとりで<br>ここにいるじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_04_0010009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:今日はたまたまよ、たまたま！<br>ふだんはみんなと食べているけど、たまたま！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT6_01_04_0010010")

	open_select_window_tag(Actor001,"Normal","PT6_01_04_0010011","PT6_01_04_0010012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃ、せっかくだから今日は一緒に食べるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_04_0010014")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT6_01_04_0010015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そうね<br>あなたがそこまで言うなら一緒に食べてあげる
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT6_01_04_0010016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:一緒に食べてくれと<br>頼んだつもりはないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_04_0010017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ふーん…<br>へええ～…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_04_0010019")

	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:な、なによ？<br>言いたいことあるならハッキリ言いなさいよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT6_01_04_0010020")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、別に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_04_0010021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:アッタマ来た！<br>もうここで今日のランチ食べちゃうんだから！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT6_01_04_0010022")

	change_face(Actor001,"Sad")

	--★★ノワール★★:どんな理屈だよ、それ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_04_0010023")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:じゃ、Ｂランチお願いね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT6_01_04_0010025")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？俺が持ってくるの？<br>っていうかおごるの？なんで？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_04_0010026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力

	--★★ギネヴィア★★:あなた、わたしに雇われているでしょ？<br>おごって当然じゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT6_01_04_0010027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:当然じゃないと思うけど…<br>わかったわかった、少し待っててくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_04_0010028")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
