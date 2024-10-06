-- このluaスクリプトは、MA_01B110_38.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera002 = SetTemplate("Actor002",-50,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor003,{-1.2,0,-3.3})
set_rot(Actor003,{0,0,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
lookat_weight_reset(Actor001)
lookat_weight_reset(Actor002)
lookat_weight_reset(Actor003)
-- ▲直接出力
-- ▼直接出力
MobM090 = get_object("m090")
set_pos(MobM090,{-0, -20.0, 0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116024)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★アーサー★★:すまん。ノワールは初めてだろうから<br>学園祭を味わわせてやりたかったんだが…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380002")

	change_face(Actor002,"Smile")

	--★★アーサー★★:その詫びと言ってはなんだが<br>俺のとっておきのヒミツを披露してやろう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:俺が義姉さんを困らせている理由を<br>話せていなかったなと思ってね
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380004")

	open_select_window_tag(Actor001,"Normal","MA_01B110_380005","MA_01B110_380006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうして今？<br>興味ないな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_380008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★アーサー★★:そう言うな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380009")

	change_face(Actor002,"Normal")

	--★★アーサー★★:王様のプライベートなんて<br>そうそう聞けんぞ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Smile")

	--★★ノワール★★:弱みを握れるかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_380012")

	change_face(Actor002,"Normal")

	--★★アーサー★★:俺の弱みでもあり<br>義姉さんの恥でもある
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380013")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★アーサー★★:聞いておいて損はないぞ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380014")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
change_face(Actor001,"Normal")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:義姉さんは俺の乳母だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380016")

	PlayAction(Actor002,"to  Std_Worry")

	--★★アーサー★★:我が母イグレーヌ付きの侍女として城に入り<br>イグレーヌは義姉さんを娘のように可愛がり…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380018")


	--★★アーサー★★:俺の養育に乳母として携わった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380019")


	--★★アーサー★★:俺を戦場から遠ざけるべく<br>孤児院に預けてからも…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380020")


	--★★アーサー★★:彼女は姉として通いつめ<br>家族として暖かく接してくれた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380021")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★アーサー★★:ただ小さいころの俺は<br>どうしようもなく甘ったれでな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380022")


	--★★アーサー★★:ログレスは今のように<br>優秀な騎士ばかりではなかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380023")


	--★★アーサー★★:俺はガキだった<br>勇敢さと無謀さを取り違えていた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380024")


	--★★アーサー★★:しばしば院を抜け出しては<br>戦場に出る父ユーサーにこっそりついていき…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380025")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★アーサー★★:…死にかけて帰ってくる日々だった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380026")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★アーサー★★:おかげでギネヴィアの奔放さには<br>なにも言えなかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_381001")


	--★★アーサー★★:死に急がんとする<br>向こう見ずなガキだった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380027")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
turn_chara(Actor003,20,0.3)
set_common_look_at(Actor001,Actor003)
set_common_look_at(Actor002,Actor003)
-- ▲直接出力

	--★★市民（中年男）★★:アーサー様！召し上がりませんか新作！<br>お安くしておきますよオッ！
	Talk(Actor003,"NPCNAME_0125","speech","N","MA_01B110_380029")

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Smile")

	--★★アーサー★★:言い値で買いに来よう！<br>今度財布を持ってな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380030")

	PlayAction(Actor003,"to Greet_one")

	--★★市民（中年男）★★:まいど！！
	Talk(Actor003,"NPCNAME_0125","speech","N","MA_01B110_380031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
lookat_delay_weight_reset(Actor002,0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:俺が血塗れで帰ってくるたび義姉さんはパニック<br>怪我を治さんと薬を探し求め島中を右往左往だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380033")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
lookat_delay_weight_reset(Actor001,0.5)
set_rot(Actor003,{0,0,0})
-- ▲直接出力

	--★★アーサー★★:俺はそれを当然と甘え、より傷をつけて帰り<br>きっかけは…なんだったかな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380034")

	change_face(Actor002,"Sad")

	--★★アーサー★★:そうしているうち<br>義姉さんは脚を壊した
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380035")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！<br>あんな、立ち上がれないほどの…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_380036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★アーサー★★:義姉さんの怪我は一向に治らなかった<br>俺の治療に明け暮れたからか…彼女の体の問題か
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380037")

	change_face(Actor002,"Normal")

	--★★アーサー★★:ともかく俺は<br>卓につくことを覚えた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380038")


	--★★アーサー★★:恥ずべき思い出だろう？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380040")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★アーサー★★:ノワール…お前は強き父に導かれ<br>家族のために剣を振るい続けている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380041")


	--★★アーサー★★:強いられた継承者の資格に<br>背を向けることなく道を歩み続けている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:いかんことだがノワール<br>俺はお前になにかを少し重ねてしまっている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380043")


	--★★アーサー★★:俺はお前に少し<br>入れ込み過ぎてしまっているのかもしれん
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380044")

	open_select_window_tag(Actor001,"Normal","MA_01B110_380045","MA_01B110_380046")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ありがとう、話してくれて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_380048")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★アーサー★★:自分語りを聞かせてしまって悪いなノワール<br>ちょっとした自己満足になってしまった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380049")

	change_face(Actor002,"Normal")

	--★★アーサー★★:だが、お前には聞いてもらいたかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:似た者同士、少し相談がしたいんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380051")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:似ているとは思えないな<br>俺と、あんたとじゃ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_380053")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★アーサー★★:…こっちの勝手な思い込みかもな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380054")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★アーサー★★:深入りはしないさ<br>憐れみもナシでいこう、お互いな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380055")

	change_face(Actor002,"Normal")

	--★★アーサー★★:まあどうしてそんな話をしたかというと<br>こんなガキには解決し切れん相談があってな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380056")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お願い？<br>そ、それが本題か…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_380058")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Normal")

	--★★アーサー★★:血なまぐさい選択はしたくない<br>だが軽薄な決断もよろしくない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380059")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:お前の馴染みの場所に<br>付き合ってほしい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01B110_380060")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116024)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
