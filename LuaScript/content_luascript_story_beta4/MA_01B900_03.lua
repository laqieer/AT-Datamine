-- このluaスクリプトは、MA_01B900_03.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera002 = SetTemplate("Actor002",321.0251,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115110)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	change_face(Actor003,"Sad")

	--★★マーリン★★:ユーサー様は妖精ニニアンと交わったことで<br>その血が穢れ始めました
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B900_030002")


	--★★マーリン★★:ニニアンはユーサー様にそれ以上呪いを<br>背負わせてはならないと姿を消し…
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B900_030003")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★マーリン★★:ユーサー様は己が穢れたことを知らぬまま<br>妖精を探し求め、しかし見つからず
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B900_030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:失意のうちに政略結婚により<br>アーサー様の母君イグレーヌ様と婚姻を結ぶ
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B900_030005")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マーリン★★:やがて穢れはユーサー様の血族──<br>つまりはアーサー様の内へ…
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B900_030006")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…その穢れこそ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_030007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★アーサー★★:世の穢れ、歴史の綻び<br>──バルバロイの因子だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_030008")


	--★★マーリン★★:アーサー様は産まれながらにして<br>バルバロイとなる素養を持ち合わせていました
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B900_030010")


	--★★マーリン★★:世の救済へ導く妖精から望まずもたらされた呪い<br>それは世の崩壊を招くバルバロイを誕生させる…
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B900_030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マーリン★★:私はアーサー様の容態をつねに監視しつつ<br>聖杯を扱うに足る継承者を待ち続けていました
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B900_030012")


	--★★マーリン★★:──妖精マーリンが、継承者を
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01B900_030013")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:貴方が…ランスロットが言っていた<br>『王のもとで護られてきた妖精』…！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_030015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:だとすれば、わからないんですか…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_030016")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:アーサーがバルバロイにならない方法は…？<br>ひ、人で居続ける手段はないのか…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_030017")

	change_face(Actor002,"Normal")

	--★★アーサー★★:ペレス王も銀卓騎士団も<br>もちろん長年その手段は探しただろう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_030018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★アーサー★★:だがあの末路…己が身を侵してでも<br>家族を生かそうという決断にしか至れなかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_030019")


	--★★アーサー★★:…遅かれ早かれ俺はバルバロイになる<br>ペレス王を見て改めて確信させられたよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_030020")

	change_face(Actor002,"Normal")

	--★★アーサー★★:だからさ<br>そのときが来るまで…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_030022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:学園のために、生徒たちのために<br>円卓の騎士の仲間のために死ねないか考えていた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_030023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:人として、誰かのために
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B900_030024")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115110)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
