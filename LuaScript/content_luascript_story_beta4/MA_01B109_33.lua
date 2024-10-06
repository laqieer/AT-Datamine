-- このluaスクリプトは、MA_01B109_33.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_001)
	Camera002 = SetTemplate("Actor002",71.1,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera003 = SetTemplate("Actor003",109.2,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115154)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")

	--★★ギネヴィア★★:ごきげんよう
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ギネヴィア、ディナタン<br>どうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_330003")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:用がなきゃ会っちゃダメ？兄さん
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B109_330004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そんなことあるわけないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_330005")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…だいじょぶ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ありがとう<br>平気だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_330007")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディナタン★★:大々的な葬儀がね、あるらしいの<br>それを兄さんにも伝えたくて
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B109_330008")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:葬儀？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_330009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:これまでの戦いで沢山亡くなったから…<br>学園をあげて弔いたいんだって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_330011","MA_01B109_330012","MA_01B109_330013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:誰の発案なのか、見当ついたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_330015")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:陛下は粋な御方なのねえ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330016")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:大勢で、笑顔で、送り出してあげたい<br>そういうことらしいわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ブライアンのことも<br>いっしょに弔ってもらえるかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_330019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:きっと、してもらえるよ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B109_330020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そっか<br>…ブライアン、喜んでくれそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_330021")

	change_face(Actor003,"Normal")

	--★★ディナタン★★:ブライアンさん<br>派手なことは嫌いじゃなかったから
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B109_330022")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:声をかけてくれたのは嬉しいけど<br>まだ少し…気持ちの整理がつけられてないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_330024")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:…そうだよね<br>落ち着く暇もなかったし…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B109_330025")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:いなくなっちゃったみんなに想いを馳せる<br>そういった機会になるはずだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330026")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…待ってるね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330027")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Sad")

	--★★ディナタン★★:それにしても、兄さん…<br>ランス兄ちゃんもそうだけど…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B109_330029")


	--★★ディナタン★★:ふたりで重いものを<br>抱えているようにも見える
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B109_330030")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんな、ことは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_330031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:私たちにはわからない、なにか…<br>言えないことなら触れはしないけれど…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B109_330032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ありがとう、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_330033")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:そーゆーのは、個々人にあるだろうし<br>噛み砕くのにも時間はかかると思うけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330034")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:だけど…みんな違う悲しみを抱えてても<br>悼む心はいっしょだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330035")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ありがとう…、ギネヴィア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_330037")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:どういたしまして<br>国葬はX日後よ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:ときどき振り返りながら…いこうね、兄さん
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B109_330039")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:あなたたちは聖杯を見つけて奇跡を起こす<br>わたしたちはローマをぶっ飛ばす
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330040")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:外交は任せて<br>大ゲンカしてやるんだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B109_330042")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115154)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
