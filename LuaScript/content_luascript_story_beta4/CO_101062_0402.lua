-- このluaスクリプトは、CO_101062_0402.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_003)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:はい！こちらがご注文の品です<br>ご確認をお願いします
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020002")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定3")
-- ▲直接出力

	--★★市民（男）★★:ああ、これです！ありがとうございます！　
	Talk(Actor003,"NPCNAME_0177","speech","N","CO_101062_04020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:よかった！では、お買い上げということで<br>では、代金についてはこちらで
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男2", "挨拶")
-- ▲直接出力

	--★★市民（男）★★:え…これでいいんですか？安すぎます！<br>苦労していただいたぶん、もっと払いますよ
	Talk(Actor003,"NPCNAME_0177","speech","N","CO_101062_04020005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★マルイル★★:いえいえ！いいんですよ<br>「正当な対価を正当な形で」です
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020006")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力

	--★★マルイル★★:この価格は手数料込みの適正価格ですから！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020007")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera001)
end
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:（へぇ…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101062_04020008")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
Appear(Actor001)
setup_small_camera_start(RndCamera002)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:どうしたんですか、ノワールさん<br>なんだか不思議そうな顔して
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020010")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101062_04020013","CO_101062_04020014")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:優しいんだな、マルイルは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:優しい？<br>いえいえ、そんなんじゃありませんよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020017")

	change_face(Actor002,"Normal")

	--★★マルイル★★:お客さんの気持ちを考えたら、むしろ<br>もらったほうが優しいのかもしれませんしね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もっと支払うって言ってたんだから<br>もらっておけばいいのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:駄目ですよ。ぼくはその品物に<br>正しいと思った値段をつけてるんですから
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020021")

	change_face(Actor002,"Anger")

	--★★マルイル★★:それより多くもらうのは祖父の教えに反するし/ぼくの信条にも反するんです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020022")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:いいですか？「正当な対価を正当な形で」/これがぼくの商人としてのモットーです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020024")


	--★★マルイル★★:なんでも高く売ればいいってものではないんです/真の商人は、店も客も豊かにするもの…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020025")


	--★★マルイル★★:誠意をもってお客さんと品物を繋げば/利益は産まれるのです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:そう、祖父がぼくに教えてくれました/祖父も商人なので、そのあたりは厳しいんです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020027")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020028")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:そういえば…ブライアンも言ってたな/報酬は高ければいいってものでもないって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020029")

	change_face(Actor002,"Surprise")

	--★★マルイル★★:ブライアン？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺の…なんというか、育ての親。傭兵なんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020031")

	change_face(Actor001,"Normal")

	--★★ノワール★★:「傭兵ってのは、買い上げられたら/報酬のぶんだけ働かなきゃならねえ」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:「だから自分の腕がどれだけの価値があるか/てめえでしっかり見極めろよ」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:なるほど。労働力も適正価格でってことですね/なんだか祖父の考えと似てる気がします！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020035")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:もしかしたらその方/祖父と気が合うかもしれません！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はは、どうかなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020037")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それにしてもあんた/ずいぶん爺さんっ子みたいだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:はい。ぼくは祖父を尊敬していますから
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020039")


	--★★マルイル★★:祖父はよく言っていました/お客さんと品物を繋ぐのが商人の役目…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020040")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルイル★★:ぼくは人当たりがいいからきっとたくさんの/品物とお客さんを繋ぐことができるって
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020041")

-- ▼直接出力
PlayPartVoice("マルイル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:その言葉がとても嬉しくて
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:だからぼくは/世界中の品物とお客さんを繋げられる…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020043")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:世界一の商人になりたい/と思うようになったんです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020044")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:立派な目標だと思うよ/それに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020045")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★ノワール★★:いい爺さんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04020046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力

	--★★マルイル★★:はい！大好きな、自慢の祖父です！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04020047")

-- ▼直接出力
local trustParam = set_communication_rankup("マルイル_コミュランク", "マルイル_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
