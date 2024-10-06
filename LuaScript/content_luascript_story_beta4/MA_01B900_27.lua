-- このluaスクリプトは、MA_01B900_27.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110061_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_006)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101036","001","101036001")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★マルディサント★★:ディーナが死ねばアタシは聖遺物化する
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B900_270002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★マルディサント★★:一度は死にかけた命だ<br>別にそれは………構わねえ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B900_270003")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:でもアンタの人生<br>ココで終わりでいいのかよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B900_270004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:このまま待っていても<br>どのみち終わりなんだよ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B900_270006")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マルディサント★★:ハーフのアンタでどうにかなる保障ねえだろ…？<br>ただのバクチに命賭けて…バカみてえじゃねえか
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B900_270007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B900_270008","MA_01B900_270009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンはどうしたいんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_270011")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★マルディサント★★:オニーサン、アンタちょっと卑怯だぜ…！？<br>ディーナは頷くことぐらいわかんだろ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B900_270012")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:マァル、やめて<br>兄さんはそんなつもりで聞いたわけじゃないよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B900_270013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:継承者として責務を果たす必要がある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_270015")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★マルディサント★★:カッコいいこと言ってっけどよ<br>ディーナを見放すってことだよなァッ！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B900_270016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:平和の願いを託して死んだ人が大勢いる<br>その命を無駄にするわけにはいかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_270017")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★マルディサント★★:いいぜオニーサン、だったらアタシも殺しなよ<br>そのあとディーナを殺しゃあイイ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B900_270018")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:やめて、マァル…！もうやめて…！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B900_270019")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★マルディサント★★:大切な人が犠牲になった平和なんざ<br>息苦しくってしょうがねえだろ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01B900_270021")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:それでも生きていって欲しいよ<br>苦しめたって、生かしたいよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B900_270023")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_270024")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ディナタン★★:けどマァル、貴方を巻き込むのも、いやだ…<br>私どうしたらいいのかな………
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B900_270025")

	change_face(Actor005,"Sad")

	--★★フィエナ2D★★:マジ妖精だよ
	Talk(Actor005,"CHRNAME_VIENA","speech","L","MA_01B900_270027")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
change_face(Actor004,"Sad")
EntryWalk(Actor004,Camera004,EntryData110061_01_06,CameraAssetBundleName110061_01,CameraPos110061_01_106)
-- ▲直接出力
-- ▼直接出力
change_face(Actor004,"Normal")
-- ▲直接出力

	--★★フィエナ★★:ディナタン、私も同じ気持ち<br>「苦しめたって、生かしたい」
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_270029")


	--★★ディナタン★★:…え？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B900_270030")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★フィエナ★★:ガラハッドと仲良くしてくれてありがとう<br>ああ見えて寂しがりやさんだから
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_270032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フィエナ★★:ノワールは…競争相手として仲良くしてくれたね<br>あなたのことを語るあの子がいちばん輝いてた
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_270033")


	--★★フィエナ★★:ディナタンとマルディサントは学友として…<br>普通の勉強があの子にとっては非日常だったから
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_270034")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:フィエナ…<br>なにをするつもりなんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_270035")

	change_face(Actor004,"Sad")

	--★★フィエナ★★:おじい様が唯一遺してくれた私の生きる道<br>おじい様とは違うやりかたで──
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_270036")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★フィエナ★★:<ruby=ガラハッド>家族</ruby>を生かすの<br>たとえ苦しめたとしても
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_270037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★フィエナ★★:ガラハッドもランスロットもいる所で<br>ちゃんと説明するね
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_270039")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:あまりにも奇跡的だからね
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B900_270040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101036","001","101036001")
MobsNo = 0
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
