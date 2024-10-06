-- このluaスクリプトは、MA_01A111_47.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:登校するのが億劫になるほど<br>退屈な学園を目指していた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_470002")


	--★★アーサー★★:刺激もなく、教師たちはうるさい、宿題は面倒で<br>昼食後の授業は眠たい、平和な学園がいい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_470003")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:竜として戦おうと決めた<br>勝利をもたらす巨躯として
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_470004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:戦いの悲劇すべては俺が食らい尽くし<br>校門の如く生徒を護れるように
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_470005")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★アーサー★★:…だが、その務めを言い訳に<br>ないがしろにしたものも多すぎたよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_470006")


	--★★アーサー★★:幼い頃から一緒に過ごしてきた義姉さんが<br>魔女──膨大なバルバロイの力を得ていた…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_470007")


	--★★アーサー★★:義姉さんが何者で、なにを隠していたのか<br>俺にはわからないんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_470008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:わかるほど<br>見ようとしていなかったのかもしれない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_470009")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力

	--★★アーサー★★:義姉を──モルガンをああさせてしまったのは<br>ほかでもなく、俺のせいだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_470010")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マーリン★★:…キラーズが、相手との絆や良き思い出──<br>正の記憶を力に換えるように
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_470011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:バルバロイは<br>負の記憶に住み着きます
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_470012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:それを受け入れ、己の存在を蝕まれながら<br>人はバルバロイに取り憑かれる
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_470013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マーリン★★:悪なる意志が助長され<br>バルバロイとして世界を喰らうことが望みとなる
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_470014")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:ですが──
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_470015")

	open_select_window_tag(Actor001,"Normal","MA_01A111_470017","MA_01A111_470018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:モルガン先生は俺たちを助けてくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_470020")

	change_face(Actor001,"Normal")

	--★★ノワール★★:どうして彼女が魔女と化したのか<br>それは俺もわからないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_470021")

	change_face(Actor001,"Normal")

	--★★ノワール★★:モルガン先生には<br>人としての心が残っていたと信じたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_470022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:魔女同士が争い合っていた<br>…モルガン先生はルーシャスに刃を向けて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_470024")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ローマやバルバロイの内部は<br>一枚岩ではないのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_470025")

	change_face(Actor003,"Normal")

	--★★マーリン★★:あるいは<br>モルガンのみが離反したものか…
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_470026")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:あの戦場に居合わせた者には<br>言い含めてありますが
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_470028")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:モルガンの素性については<br>ご内密に
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_470029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:「アーサーをお願い」と言っていた<br>俺に言ってくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_470031")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:そのつもりでいてくれ、アーサー
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_470032")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
