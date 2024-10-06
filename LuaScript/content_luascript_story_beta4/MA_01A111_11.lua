-- このluaスクリプトは、MA_01A111_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
set_pos(Actor002, {0.223, 0, -6.752}) 
turn(Actor002,0,-178, 0,0)
turn(Actor003,0,143.035, 0,0)
Hide(Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor001,Camera001,EntryData110101_01_07,CameraAssetBundleName110101_01,CameraPos110101_01_107)
turn_lookat(Actor003,Actor001,0.5)
 --PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:山登りは得意か、アーサー？
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A111_110002")

-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ランス。知ってるだろう？<br>俺はなんでも器用にこなせてしまうほうなんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:まあ、ふもとから見上げててもらうのが<br>安心だがな
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A111_110004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:履き物も新調してるんだ<br>寂しいことを言うなよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110005")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力

	--★★ランスロット★★:…ローマも登山に向けて<br>万全の準備をしてくるだろう
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A111_110006")

	change_face(Actor001,"Sad")

	--★★ランスロット★★:だがアーサー<br>お前はもう、いいんだぞ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A111_110007")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:なんの話だかわからんな？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ランスロット★★:これからは俺がお前のそばにいられる<br>望まぬ最期をお前が迎えることはもうない
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A111_110009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:そのために目指した『最強騎士』だ<br>だから──
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A111_110010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:お前との友愛は<br>俺を救ってくれたよ。ランス
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110011")


	--★★アーサー★★:だが、厄介な父の負債は<br>もうひとつ遺っている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110012")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:いやあ、王様は辛いよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:王のために騎士がいる<br>…もうすぐゆっくりできるだろう、アーサー
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A111_110014")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:働かずにメシを食いたいもんだな、ランス
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110015")

-- ▼直接出力

CloseTalkWindow()
DontChangeRandomCamera(true)
on_camera(Camera001)
PlayActionDirect(Actor001,"to Bow")
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor001)
setup_small_camera_start()
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)

-- ▲直接出力
-- ▼直接出力
on_camera(Camera002)
turn_lookat(Actor003,Actor002,0.5)
PlayActionDirect(Actor003,"to Wlk")
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力

	--★★アーサー★★:…もうすぐだ<br>もうすぐだよランス
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:時は間近、となれば<br>聖杯と継承者の<ruby=つるぎ>劔</ruby>は築かねばなりませんね
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_110018")


	--★★マーリン★★:『聖域』を
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_110019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★マーリン★★:よいのですか<br>ノワール様とギネヴィア様にお話しされなくて
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_110020")


	--★★アーサー★★:今話してどうなる<br>ただ俺が楽になるだけだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110021")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:これからあいつらになにを強いるかが<br>変わるわけでもないんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110022")


	--★★アーサー★★:…この程度の胸の痛みなど<br>なんの償いにもなりはしない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力

	--★★マーリン★★:アーサー<br>それでもあなたは彼らに──
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A111_110024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:選択肢を作ってやらなきゃな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_110025")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
