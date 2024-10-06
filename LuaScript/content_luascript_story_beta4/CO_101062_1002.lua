-- このluaスクリプトは、CO_101062_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
-- ▼直接出力
load_image("103050210", "content_still_10305021_image", "103050210_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0057")
-- ▲直接出力

	--★★ノワール★★:あれ、手紙が2通
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020002")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:はい！いつもの業務報告と…<br>それから、祖父からの手紙です！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0052")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:爺さんから？<br>ってことは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101062_10020006","CO_101062_10020007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0060")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:元気になったのか。よかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:はい！薬がバッチリ効いたみたいです！<br>あの薬は本当にすごいですね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020010")

	change_face(Actor002,"Normal")

	--★★マルイル★★:たとえぼくにバルバロイは倒せないとしても<br>ノワールさんとなら、苦しむ人を救えます
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:これは「お客様の願いを知れ」ですよ<br>祖父と同じ苦しみに合っている人を救って
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020012")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Normal")

	--★★マルイル★★:それが結果として、世界一の商人への道筋に<br>なるかもしれませんよ！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020013")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そのためには仕入れも頑張らなきゃな<br>護衛の依頼があれば、いつでもどうぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020014")

-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:ノワールさん…<br>本当に、頼りになる傭兵さんですね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:薬は本物だったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020017")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:ええ！？<br>疑ってたんですか！？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020018")

-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0049")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、そういうわけじゃないけど！<br>ちょっと心配はしてた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:だから、無事元気になってよかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020020")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:これもノワールさんのおかげです本当にありがとうございました！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020022")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:頑張ったのはマルイルだろ俺は護衛をしただけだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020023")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★ノワール★★:爺さんもあんたを認めたんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力

	--★★マルイル★★:はい。立派な商人になったなってぼくを褒めてくれました
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020025")

	change_face(Actor002,"Normal")

	--★★マルイル★★:それで…手紙に書いてあったんですぼくが小さな店を任された理由
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020026")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力

	--★★マルイル★★:最初、父や兄たちはぼくにもっと大きな店を任せるつもりだったそうです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020027")


	--★★マルイル★★:ぼくの商才があれば店をさらに大きくできるってでも、祖父がそれを止めたんですって
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020028")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルイル★★:「マルイルには夢がある大きな店をもたせては足枷になるかもしれない」
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020029")

-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:「時は金なり」ですよ世界一の商人を目指せると思ってくれたからこそ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020030")


	--★★マルイル★★:見聞を広める妨げになるものを持たせない<br>それが祖父の真意だったみたいです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020031")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:夢…世界中の品物とお客さんを繋ぐ世界一の商人になること、か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020032")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:爺さんはあんたのことをちゃんと大事に思っていたってわけだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020033")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:目利きには自信があったんですけど…祖父の真意に気づけないなんて、まだまだです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020034")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:見守られているほうは気づかないもんだ早くに気づけてよかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020035")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:はい！祖父の期待を裏切るわけにはいきません！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020036")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Normal")

	--★★マルイル★★:世界一の商人になるためにぼくはもっともっと、精進していきます！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020037")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera003)
wait_time(0.7)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そうだな。…俺も頑張るよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020038")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★マルイル★★:ねえ、ノワールさん
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020040")

-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0057")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだ？急にあらたまって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020041")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力

	--★★マルイル★★:詳しく存じ上げているわけではないですが
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020042")


	--★★マルイル★★:ノワールさんが大変な役目を負わされているって聞いてます
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020043")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルイル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:負わされている、っていうのは変ですかね<br>きっとご自身で進んでやっていることだろうから
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020045")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:マルイル…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:あなたはそういう方ですみんなのためになにかができる、立派な方です
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020047")


	--★★マルイル★★:ひょっとしたら挫けそうになることもあるかもしれません
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020048")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力

	--★★マルイル★★:そんなときも、ノワールさんなら「なにくそ！」って頑張っちゃうと思います
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020049")


	--★★マルイル★★:でも、ときどきは心と体をマッサージしてあげてください
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:「押しても駄目なら引いてみろ」商売も人生もそういうものですよ
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020051")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0053")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…マルイル、ありがとう肝に銘じておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_10020052")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:お礼を言うのはこっちですよ！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020053")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:ノワールさん<br>本当にありがとうございました！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_10020054")

-- ▼直接出力
CloseTalkWindow()
show_image("103050210", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) 
set_scale_image(0.9,0.9) 
wait_time(1.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:これからも商人として協力しますからご入用のものがあればなんでも言ってくださいね
	Talk(Actor002,"CHRNAME_MARIL","simple","N","CO_101062_10020055")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("マルイル_コミュランク", "マルイル_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103050210", "content_still_10305021_image", "103050210_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
