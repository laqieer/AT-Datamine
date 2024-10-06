-- このluaスクリプトは、MA_01A112_46.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",110,CharaPos110141_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_002)
	Camera002 = SetTemplate("Actor002",-70,CharaPos110141_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_005)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115144)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:モルガンの真意は<br>今となっては測りかねますが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460002")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★マーリン★★:モルガンのリンゴは<br>彼女の穢れなき力の塊でした
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マーリン★★:大気中に漂うバルバロイの因子が<br>稀に人体へと影響を及ぼす『狂忘症』
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460005")


	--★★マーリン★★:その病の進行を遅らせるため<br>モルガンはリンゴに祈りと力を込めた
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460006")


	--★★マーリン★★:生徒たちのバルバロイへの抵抗力は高まり<br>ブライアンやマルディサントは長らえた
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A112_460008","MA_01A112_460009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ブライアンにもリンゴを与えていたんですか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_460011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:かつてライエンスが<br>学園に接近したときがあったでしょう
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460012")

	change_face(Actor002,"Sad")

	--★★マーリン★★:ブライアンはライエンスの因子に共鳴し<br>学園の牢内でバルバロイ化直前でした
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460013")

	change_face(Actor002,"Normal")

	--★★マーリン★★:それを回避させたのがモルガンのリンゴです<br>バルバロイの因子を抑制し、彼を長らえさせた…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:マルディサントを…<br>ずっと助けていたんですね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_460016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:リンゴを与えていたのが<br>助けるためであったかまでは断定できませんが…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460017")

	change_face(Actor002,"Sad")

	--★★マーリン★★:言葉は悪いですが<br>手懐けるため…だった可能性もなくはない
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460018")

	change_face(Actor002,"Normal")

	--★★マーリン★★:ただ事実として<br>モルガンのリンゴが救った者は多かった
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460019")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("マーリン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:アーサー様をお救いしたいモルガンの意志は<br>バルバロイと混ざり黒く歪んでいきましたが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460021")

	change_face(Actor002,"Anger")

	--★★マーリン★★:学園を癒すという彼女の心意気は<br>最期まで魔女の支配に抗った
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460022")

	change_face(Actor002,"Sad")

	--★★マーリン★★:その芯まで腐っていたか否かは──
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力

	--★★マーリン★★:皮すら剥けぬ今<br>わからぬことですが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_460024")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115144)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
