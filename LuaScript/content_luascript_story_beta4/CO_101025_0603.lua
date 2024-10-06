-- このluaスクリプトは、CO_101025_0603.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110161_02","110161_02_h")
Include("content_adv_advsmall_110161_02","Template110161_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110161_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_002)
	Camera002 = SetTemplate("Actor002",-15,CharaPos110161_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110161_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_004)
	InitializeTemplateRandomCamera110161_02()
	InitializeTemplate110161_02()
-- ▼直接出力
DontChangeRandomCamera(true)
Prop_01 = get_object("geo_desk_item_09")
set_pos(Prop_01, {0,0,1.6})
Prop_02 = get_object("geo_chair_14")
set_pos(Prop_02, {1.05,0,3.13})
set_rot(Prop_02,{0,0,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight_default(Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110161)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:結局、取り合ってもらえなかったな
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_06030002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:でも、俺もこの事件は<br>バルバロイによるものじゃないと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力

	--★★クレア★★:それはどうして？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030004")

	open_select_window_tag(Actor001,"Normal","CO_101025_06030006","CO_101025_06030007","CO_101025_06030008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイに喰われたなら<br>俺たちは彼のことを忘れているはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:バルバロイに喰われてしまった者は<br>家族にすらその存在を忘れられる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030012")

	change_face(Actor002,"Normal")

	--★★クレア★★:遺族が遺体を引き取りにくることはないわ<br>だから、この事件は人間の手によるものよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:遺体の損傷が<br>バルバロイによるものとは思えなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:それは間違いではないけれど<br>あなたは大事なことを見落としているわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030016")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クレア★★:もしもバルバロイの喰われたのなら<br>なぜわたしたちは彼のことを覚えているの？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030017")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ、そうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:えーっと、その…探偵としてのカン、かな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:ノワール<br>そのカンは間違っていないけれど
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030021")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クレア★★:これはカンも推理も必要なく<br>わたしたちならわかって当然のことなの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030022")

	change_face(Actor002,"Normal")

	--★★クレア★★:バルバロイに喰われてしまった者は<br>周囲からその存在を忘れられる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クレア★★:わたしたちは彼のことを覚えている<br>つまり、彼はバルバロイに喰われたのではない
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030024")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:人間の手によるものだとすると<br>血の蒐集家の仕業なんだろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030026")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:郵便配達人を殺害し<br>バルバロイによる被害にしようとしているのは
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030027")


	--★★クレア★★:あの料理人を名乗った男であることに<br>間違いはないと思う
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030028")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★クレア★★:でも、あの男は血の蒐集家ではない
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030029")


	--★★ノワール★★:どうしてそう思うんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030030")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_No")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:すべてが浅はかで稚拙なのよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030031")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor003,true)
-- ▲直接出力

	--★★クレア★★:あの男が本当に血の蒐集家なのであれば<br>目立つ場所に手がかりを残すはずがないし
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030033")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★クレア★★:目くらましのために<br>関係のない人間を殺害したりなどしない
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030035")

-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ど、どうしたクレア？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030037")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:そんなヤツにおじいちゃんが<br>やられるわけないのよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030039")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:わたしのおじいちゃんは<br>海の向こうで探偵をやっていたの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030041")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★クレア★★:どんな難事件も瞬く間に解決してしまうと評判で<br>依頼人が途切れることはなかったわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030042")

	PlayAction(Actor002,"to  Std_Worry")

	--★★クレア★★:おじいちゃんはわたしの自慢で…<br>わたしが探偵に憧れることになったきっかけ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030043")


	--★★クレア★★:おじいちゃんは数年にわたって<br>血の蒐集家を調べていたわ。そして
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:「記憶を奪う魔物と<br>血の蒐集家とは関係性がある」
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030045")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★クレア★★:わたしにそう言い残して調査に向かい<br>…帰らぬ人となったわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030046")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ひょっとしてバルバロイに喰われたのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030047")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:それは違うわ<br>わたしからおじいちゃんの記憶は消えてない
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:ただ、犠牲者のなかにはバルバロイに<br>喰われてしまったのではないかとされる人もいる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030050")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030051")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:事件の数と被害にあったとされる者の<br>数が合わないのよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030052")


	--★★クレア★★:なんらかの意図をもって記憶を消した者がいる<br>そう考えるのが自然ね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030053")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なるほど<br>けど、なんでわざわざそんなことをしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030054")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力

	--★★クレア★★:そうね…あくまでわたしの推測にすぎないけれど<br>忘れられた悲劇をあえて作ることで
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030055")


	--★★クレア★★:忘れたほうがよかったと思えるくらいの悲劇を<br>より強く演出しようとしているのかもしれない
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030056")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それが本当だとしたら<br>悪趣味ってレベルじゃないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030058")

-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:バルバロイを根絶する<br>それはすごくだいじなことだけれど
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030059")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★クレア★★:この世界はバルバロイに連なる悪…<br>ひょっとしたらバルバロイより邪悪な存在がいる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030060")

	change_face(Actor002,"Anger")

	--★★クレア★★:わたしはおじいちゃんの後を継いで<br>それを追っているの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030061")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クレア★★:この学園に来たのも調査のためよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030062")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:…密航までしてな
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_06030063")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もしかしてキラーズになったのも<br>いざってときに血の蒐集家と戦うためなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030064")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:ええ。それも理由のひとつね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030065")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:…話が逸れてしまったわ<br>ここで一度状況を整理してみましょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030067")


	--★★クレア★★:ロンディニウムの周辺で獣を殺害する事件を<br>起こしたのは、現場に現れた料理人を名乗る男
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030068")


	--★★クレア★★:男は次にログレスで事件を起こそうとしたが<br>『儀式』を行うために必要な呪具が足りなかった
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030069")


	--★★クレア★★:呪具がそろうのを待つあいだに<br>男はログレスに住む子供をさらい
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030070")


	--★★クレア★★:そのあと、人目を避けるためにログレスから逃走<br>その過程で郵便配達人の男性を殺害した
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030071")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クレア★★:…仮定は多いけれど<br>こんなところかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030072")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:郵便配達人は儀式に必要な品を<br>犯人に届けたんだろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030073")


	--★★ノワール★★:手に入れてしまったのであれば<br>犯人はすぐにでも犯行に及ぶ恐れがある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030074")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★クレア★★:たぶん、それは大丈夫<br>遺体のそばにあった書状に
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030075")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クレア★★:「トラブルで依頼の品の準備にしばらくかかる」<br>と書かれていたから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030076")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いつの間にそんなことを調べてたんだ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06030077")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:教えたでしょう？<br>探偵の心得のひとつよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030078")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:今日はこのあたりにしましょう<br>なにか動きが合ったらまた伝えるわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06030079")

-- ▼直接出力
local trustParam = set_communication_rankup("クレア_コミュランク", "クレア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110161)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110161_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
