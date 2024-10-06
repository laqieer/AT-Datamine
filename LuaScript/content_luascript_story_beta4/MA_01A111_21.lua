-- このluaスクリプトは、MA_01A111_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111021_01","111021_01_h")
Include("content_adv_advsmall_111021_01","Template111021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111021_01,CameraPos111021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111021_01,CameraPos111021_01_006)
	InitializeTemplateRandomCamera111021_01()
	InitializeTemplate111021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111021)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:ログレスは今のように<br>優秀な騎士ばかりではなかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210002")

	change_face(Actor002,"Sad")

	--★★アーサー★★:俺はガキだった<br>勇敢さと無謀さを取り違えていた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:しばしば院を抜け出しては<br>戦場に出る父ユーサーにこっそりついていき…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210004")


	--★★アーサー★★:…死にかけて帰ってくる日々だった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210005")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:おかげでギネヴィアの奔放さに<br>なにも言えなかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:死に急がんとする<br>向こう見ずなガキだった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210007")

	change_face(Actor002,"Sad")

	--★★アーサー★★:俺が血塗れで帰ってくるたび義姉さんはパニック<br>怪我を治さんと薬を探し求め島中を右往左往だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210009")


	--★★アーサー★★:俺はそれを当然と甘え、より傷をつけて帰り<br>きっかけは…なんだったかな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210010")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力

	--★★アーサー★★:そうしているうち<br>義姉さんは脚を壊した
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210011")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！<br>あんな、立ち上がれないほどの…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_210012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:義姉さんの怪我は一向に治らなかった<br>俺の治療に明け暮れたからか…彼女の体の問題か
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210013")

	change_face(Actor002,"Normal")

	--★★アーサー★★:ともかく俺は<br>卓につくことを覚えた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:恥ずべき思い出だろう？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210016")


	--★★アーサー★★:ノワール…お前は強き父に導かれ<br>家族のために剣を振るい続けている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210017")


	--★★アーサー★★:強いられた継承者の資格に<br>背を向けることなく道を歩み続けている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:いかんことだがノワール<br>俺はお前になにかを少し重ねてしまっている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210019")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★アーサー★★:俺はお前に少し<br>入れ込み過ぎてしまっているのかもしれん
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210020")

	open_select_window_tag(Actor001,"Normal","MA_01A111_210022","MA_01A111_210023")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ありがとう、話してくれて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_210025")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:自分語りを聞かせてしまって悪いなノワール<br>ちょっとした自己満足になってしまった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:だが、お前には聞いてもらいたかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:似ているとは思えないな<br>俺と、あんたとじゃ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_210029")

	change_face(Actor002,"Normal")

	--★★アーサー★★:…こっちの勝手な思い込みかもな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:深入りはしないさ<br>憐れみもナシでいこう、お互いな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A111_210031")

	goto Block1end

::Block1end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111021)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
