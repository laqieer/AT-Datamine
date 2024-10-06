-- このluaスクリプトは、MA_01A109_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115154)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:元気か、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ランスロット、ディナタン<br>どうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_120003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:用がなきゃ会っちゃダメ？兄さん
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120004")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなことあるわけないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_120005")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディナタン★★:大々的な葬儀がね、あるらしくて<br>それを兄さんにも伝えに来たの
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120006")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:葬儀？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_120007")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:少なくともロンディニウムの騒ぎが一段落し<br>城下が落ち着いてからになるだろうが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:これまでの戦いで多くの命を亡くした<br>学園をあげて弔いたいと、アイツが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120009")

	open_select_window_tag(Actor001,"Normal","MA_01A109_120011","MA_01A109_120012","MA_01A109_120013")
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
	change_face(Actor001,"Normal")

	--★★ノワール★★:誰の発案なのか、見当ついたよ<br>アーサーらしい計らいだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_120015")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:陛下は粋な御方だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120016")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:大勢で、笑顔で、送り出してあげたい<br>そういうことらしい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ブライアンも、喜んでくれるかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_120019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:きっと
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120020")

	change_face(Actor003,"Smile")

	--★★ディナタン★★:ブライアンさん<br>派手なことは嫌いじゃなかったから
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120021")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:声をかけてくれたのは嬉しいけど<br>まだ少し…気持ちの整理がつけられてないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_120023")

	change_face(Actor003,"Sad")

	--★★ディナタン★★:…そうだよね<br>落ち着く暇もなかったし…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120024")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:死者に想いを馳せる<br>そういった機会になるはずだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120025")

	goto Block1end

::Block1end::
	change_face(Actor003,"Sad")

	--★★ディナタン★★:…それになんだか、兄さん…<br>ランス兄ちゃんもそうだけど…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120027")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力

	--★★ディナタン★★:ふたりで重いものを<br>抱えているようにも見える
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120028")

-- ▼直接出力
turn_chara(Actor002,15,0.5)
PlayActionDirect(Actor002,"to  Std_Talk")
 --PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:どうしてそう思う？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:私はふたりの妹だよ？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120031")

	change_face(Actor001,"Normal")

	--★★ノワール★★:お見通しか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_120032")

	change_face(Actor003,"Sad")

	--★★ディナタン★★:私にはわからない、なにか…<br>言えないことなら詮索はしないけれど
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…ありがとう、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_120034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:ときどき振り返りながら…いこうね、兄さん
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120035")

-- ▼直接出力
turn_chara(Actor002,87,0.5)
PlayActionDirect(Actor002,"to  Std_Talk")
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:出撃まで少し猶予があるのなら<br>弔いの花でも用意すると良い
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120036")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:花…、花か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_120037")

	change_face(Actor003,"Sad")

	--★★ディナタン★★:「この非常時にかあ」<br>「ギネヴィアなんか頑張ってるのになあ」
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120038")

	change_face(Actor003,"Normal")

	--★★ディナタン★★:そういうカオ
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A109_120039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:み、見通すな、顔色を…！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01A109_120040")

	close_cutin()
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:俺たちは忘れてはいけない…忘れないために<br>少し手間のかかることをする時間も必要だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:俺は必ず聖杯を<br>お前のもとに持ち帰ってみせる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120042")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…ランスロット、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_120043")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:俺たちには<br>色んなことが起こり過ぎた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:飲み込む時間も必要だ。ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A109_120046")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
