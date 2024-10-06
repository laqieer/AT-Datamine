-- このluaスクリプトは、MA_01A110_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:戦わされてるんだよ、俺たち<br>そうしなきゃ生きていけないから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:…はい
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だけど…「してしまった」なんて<br>思いたくないじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130004")


	--★★ノワール★★:エレインが選んで、兄さんが決めて<br>今のキミがあるんだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エレイン★★:はい…っ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130006")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そのときの覚悟を<br>後悔に変えちゃいけない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ＧＳがどうしようもなく憎らしいのなら<br>なくせるように頑張ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:なくなりませんよ…っ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130009")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:戦いを、平和に変えれば
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:もう傷つけなくて済む
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130012")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは辛い道だろうけど<br>途方に暮れるほど困難だろうけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:立ち止まって傷を負わせる日々が続くよりいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130014")

-- ▼直接出力
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…先輩、あなたは──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_130017","MA_01A110_130018","MA_01A110_130019")
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
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:エレインなら出来る
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130021")

	change_face(Actor001,"Smile")

	--★★ノワール★★:キミに力があるのは見たんだ<br>どうしようか悩んでいた時間が力になったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130022")

-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:自信はありません、自信は持てませんが<br>私、先輩がそう言うなら
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:頑張って、みます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:一緒に進もう<br>まだ俺も変わってる途中だから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:キミに力があるのは見たんだ<br>どうしようか悩んでいた時間が力になったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130029")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…先輩
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:それ、すごく嬉しい言葉です。なによりも<br>きっと辛くても、もっと大変でも
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130031")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアもいる<br>キミに言葉をかけてくれた彼女も
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130033")

-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:ギネヴィア様も、きっとずっと<br>頑張ってこられたんですよね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:わかるような気が、します<br>先輩があの人を選んだ意味が
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130035")

	change_face(Actor002,"Sad")

	--★★エレイン★★:だったら、私も
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130036")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★エレイン★★:…先輩の、後輩ですよね、私
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130038")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:？そう、だね…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_130039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:なら、ついていきます<br>先輩の、あとを
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130040")

-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:おかわり、いりますか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_130042")

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
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
